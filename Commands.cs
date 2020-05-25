using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using HypixelSkybot.Extensions;
using Newtonsoft.Json.Linq;

namespace HypixelSkybot
{
    public static class Commands
    {
        
        public static void Watch(ISocketMessageChannel channel, string[] args)
        {
            if (args.Length <= 0)
            {
                channel.SendMessageAsync($"Please provide a username to watch a profile for.");
                return;
            }
            var uuid = Minecraft.UsernameToUuid(args[0])["id"].Value<string>();
            var jProfiles = Hypixel.Player(uuid)["player"]["stats"]["SkyBlock"]["profiles"];
            
            var profiles = new Dictionary<string, string>();
            var options = new List<string>();
            foreach (var prof in jProfiles)
            {
                var i = profiles.Count + 1;
                var p = prof.First();
                var id = p["profile_id"].Value<string>();
                var name = p["cute_name"].Value<string>();
                profiles.Add(name, id);
                options.Add(name);
            }

            channel.SendMultipleChoiceAsync("These are the profiles i found", options, option =>
            {
                profiles.TryGetValue(option, out var id);
                var profile = Hypixel.SkyblockProfile(id)["profile"];
                HypixelSkybot.Create(channel, profile);
                channel.SendMessageAsync("Im now watching " + option + " in this channel");
                
            });
        }

        public static void UnWatch(ISocketMessageChannel channel, string[] args)
        {
            HypixelSkybot.Remove(channel);
            channel.SendMessageAsync($"Ok i will shut up now :(");
        }
        
        public static void Kills(ISocketMessageChannel channel, string[] args)
        {
            if (!HypixelSkybot.TryGet(channel, out var skybot))
            {
                channel.SendMessageAsync("Im not watching a profile in this channel yet, use !watch first");
            }
            else
            {
                var sb = new StringBuilder();
                foreach (var profile in skybot)
                {
                    sb.Append(profile.Username);
                    sb.Append(" has a total of ");
                    sb.Append(profile.GetCurrentStat(ProfileUser.ZealotKills));
                    sb.AppendLine(" zealot kills.");
                }

                channel.SendMessageAsync(sb.ToString());
            }
        }
        
        public static void Deaths(ISocketMessageChannel channel, string[] args)
        {
            if (!HypixelSkybot.TryGet(channel, out var skybot))
            {
                channel.SendMessageAsync("Im not watching a profile in this channel yet, use !watch first");
            }
            else
            {
                var sb = new StringBuilder();
                foreach (var profile in skybot)
                {
                    sb.Append(profile.Username);
                    sb.Append(" has a total of ");
                    sb.Append(profile.GetCurrentStat(ProfileUser.Deaths));
                    sb.AppendLine(" deaths.");
                }

                channel.SendMessageAsync(sb.ToString());
            }
        }

        public static void Alchemy(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Alchemy);
        public static void Taming(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Taming);
        public static void Mining(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Mining);
        public static void Foraging(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Foraging);
        public static void Enchanting(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Enchanting);
        public static void Carpentry(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Carpentry);
        public static void Farming(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Farming);
        public static void Combat(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Combat);
        public static void Fishing(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Fishing);
        public static void Runecrafting(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Runecrafting);
        public static void Revenant(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Revenant);
        public static void Tarrantula(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Tarrantula);
        public static void Wolf(ISocketMessageChannel channel, string[] args) => SkillCommand(channel, LevelType.Wolf);

        private static void SkillCommand(ISocketMessageChannel channel, LevelType levelType)
        {
            
            if (!HypixelSkybot.TryGet(channel, out var skybot))
            {
                channel.SendMessageAsync("Im not watching a profile in this channel yet, use !watch first");
            }
            else
            {
                var sb = new StringBuilder();
                foreach (var profile in skybot)
                {
                    var level = profile[levelType];
                    sb.Append(profile.Username);
                    sb.Append(" is ");
                    sb.Append(levelType.ToString().ToLower());
                    sb.Append(" level ");
                    sb.Append(level.CurrentLevel.ToString());
                    sb.Append(" with ");
                    sb.Append(level.Xp);
                    sb.Append("/");
                    sb.Append(level.XpForLevelup);
                    sb.AppendLine("xp.");
                }

                channel.SendMessageAsync(sb.ToString());
            }
        }
    }
}