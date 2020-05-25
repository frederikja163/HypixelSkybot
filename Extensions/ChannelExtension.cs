using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Discord;
using Discord.Rest;
using Discord.WebSocket;

namespace HypixelSkybot.Extensions
{
    public static class ChannelExtension
    {
        private class ReactionWatcher
        {
            private ulong _id;
            public ulong Id
            {
                get => _id;
                set
                {
                    _id = value;
                    _watchers.TryAdd(value, this);
                }
            }

            public Dictionary<string, string> Options { get; } = new Dictionary<string, string>();
            public Action<string> OptionChosen { get; set; }
        }

        private static Dictionary<ulong, ReactionWatcher> _watchers = new Dictionary<ulong, ReactionWatcher>();
        
        public static void DispatchReaction(Cacheable<IUserMessage, ulong> arg1, ISocketMessageChannel arg2, SocketReaction arg3)
        {
            if (_watchers.TryGetValue(arg3.MessageId, out var reaction))
            {
                var emote = arg3.Emote.Name;
                if (reaction.Options.TryGetValue(emote, out var option))
                {
                    reaction.OptionChosen.Invoke(option);
                    _watchers.Remove(reaction.Id);
                }
            }
        }
        
        public static Task<RestUserMessage> SendMultipleChoiceAsync(this ISocketMessageChannel channel, string title,
            IEnumerable<string> options, Action<string> optionChosen)
        {
            var reaction = new ReactionWatcher();
            reaction.OptionChosen = optionChosen;
            
            var embed = new EmbedBuilder()
                .WithTitle(title)
                .WithDescription("Choose one by reacting with an emoji")
                .WithColor(Color.Red);
            var i = 0;
            var emotes = new List<Emoji>();
            foreach (var o in options)
            {
                var emote = ++i + "⃣";
                emotes.Add(new Emoji(emote));
                embed.AddField(emote, o);
                reaction.Options.Add(emote, o);
            }

            var returnVal = channel.SendMessageAsync(embed: embed.Build());
            var message = returnVal.Result;
            reaction.Id = message.Id;
            message.AddReactionsAsync(emotes.ToArray());
            new Timer((o) => _watchers.Remove(reaction.Id), null, 60000, int.MaxValue);
            
            return returnVal;
        }
    }
}