using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace HypixelSkybot
{
    public static class Commands
    {
        public static void Watch(ISocketMessageChannel channel, string[] args)
        {
            channel.SendMessageAsync($"Im looking up the profile {args[0]}");
            var profile = Hypixel.SkyblockProfile(args[0])["profile"];
            HypixelSkybot.Create(channel, profile);
            channel.SendMessageAsync("Im now watching " + args[0] + " in this channel");
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
    }
}