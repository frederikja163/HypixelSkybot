using System;

namespace HypixelSkybot
{
    public class ProfileUser
    {
        private const string ZealotKills = "kills_zealot_enderman";
        private const string Deaths = "deaths";
        private Member Last;
        private Member Current;
        
        public string UserId { get; }
        public string Username { get; }
        
        public ProfileUser(string userId, string username)
        {
            UserId = userId;
            Username = username;
        }

        public void Tick(Member current)
        {
            Last = Current;
            Current = current;
            if (Last == null)
            {
                return;
            }

            if (Math.Floor(Current.Stats[ZealotKills] / 1000) > Math.Floor(Last.Stats[ZealotKills] / 1000))
            {
                DiscordBot.SendMessage($"{Username} has killed more than {Math.Floor(Current.Stats[ZealotKills] / 1000)}000 zealots!");
            }
            
            if (Current.Stats[Deaths] >= Last.Stats[Deaths])
            {
                foreach (var (name, value) in Current.Stats)
                {
                    if (name.StartsWith($"{Deaths}_"))
                    {
                        if (value > Last.Stats[name])
                        {
                            DiscordBot.SendMessage($"{Username} just died to {name.Substring(Deaths.Length + 1)}");
                            break;
                        }
                    }
                }
            }
        }
    }
}