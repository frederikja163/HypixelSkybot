using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace HypixelSkybot
{
    public class DiscordBot : IDisposable
    {
        private DiscordSocketClient _bot;
        private Dictionary<string, Command> _commands = new Dictionary<string, Command>();
        private delegate void Command(ISocketMessageChannel channel, string[] args);
        
        public DiscordBot(string token)
        {
            _bot = new DiscordSocketClient();
            
            _bot.LoginAsync(TokenType.Bot, token);
            _bot.StartAsync();

            _bot.MessageReceived += msg =>
            {
                OnMessageReceivedAsync(msg);
                return Task.CompletedTask;
            };

            var commands = typeof(Commands).GetMethods();
            foreach (var c in commands)
            {
                var d = (Command)Delegate.CreateDelegate(typeof(Command), c, false);
                if (d != null)
                {
                    _commands.TryAdd(c.Name.ToLower(), d);
                }
            }
        }
        
        private void OnMessageReceivedAsync(SocketMessage msg)
        {
            if (!msg.Content.StartsWith('!'))
            {
                return;
            }

            var comStr = msg.Content;
            var argPos = comStr.IndexOf(' ');
            var com = comStr.Substring(1, (argPos == -1 ? comStr.Length : argPos) - 1);
            if (_commands.TryGetValue(com.ToLower(), out var c))
            {
                var args = comStr.Substring(argPos + 1).Split(' ');
                c.Invoke(msg.Channel, args);
            }
            else
            {
                msg.Channel.SendMessageAsync("Command does not exist.");
            }
        }
        
        public void Dispose()
        {
            _bot.LogoutAsync();
        }
    }
}