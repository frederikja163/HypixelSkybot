using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace HypixelSkybot
{
    public static class HypixelSkybot
    {
        private static Timer _timer;
        private static readonly List<ProfileUser> _users = new List<ProfileUser>();
        
        public static void StartTimer(string skyblockId)
        {
            _timer = new Timer(30000);
            _timer.AutoReset = true;
            _timer.Elapsed += (sender, eventArgs) => TimerTick();
            _timer.Start();

            var profile = Hypixel.SkyblockProfile("b99305ae64c24754a8328d09fad3c83b");
            foreach (var (uuid, member) in profile.Profile.Members)
            {
                var username = Minecraft.UuidToUsername(uuid).Last().Name;
                _users.Add(new ProfileUser(uuid, username));
            }
            
            TimerTick();
        }

        private static void TimerTick()
        {
            var profile = Hypixel.SkyblockProfile("b99305ae64c24754a8328d09fad3c83b");
            foreach (var user in _users)
            {
                var member = profile.Profile.Members[user.UserId];
                user.Tick(member);
            }
        }
    }
}