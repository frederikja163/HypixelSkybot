using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Timers;
using Discord.WebSocket;
using HypixelSkybot.Extensions;
using HypixelSkybot.SkyblockProfileReturn;
using Newtonsoft.Json.Linq;

namespace HypixelSkybot
{
    public class HypixelSkybot : IEnumerable<ProfileUser>
    {
        private static Timer _timer;
        private string _skyblockId;
        private ISocketMessageChannel _channel;
        private readonly List<ProfileUser> _users = new List<ProfileUser>();
        private static readonly Dictionary<ISocketMessageChannel, HypixelSkybot> _skybots = new Dictionary<ISocketMessageChannel, HypixelSkybot>();
        
        public HypixelSkybot(ISocketMessageChannel channel, JToken user)
        {
            _channel = channel;
            _skyblockId = user["profile_id"].Value<string>();
            _timer = new Timer(30000);
            _timer.AutoReset = true;
            _timer.Elapsed += (sender, eventArgs) => TimerTick();
            _timer.Start();

            var profile = Hypixel.SkyblockProfile(_skyblockId);
            foreach (var member in profile["profile"]["members"])
            {
                var uuid = member.Name();
                var username = Minecraft.UuidToUsername(uuid).Last().Name;
                _users.Add(new ProfileUser(_channel, uuid, username));
            }
            
            TimerTick();
        }

        public static void Create(ISocketMessageChannel channel, JToken user)
        {
            _skybots.TryAdd(channel, new HypixelSkybot(channel, user));
        }

        public static bool TryGet(ISocketMessageChannel channel, out HypixelSkybot skybot)
        {
            return _skybots.TryGetValue(channel, out skybot);
        }

        private void TimerTick()
        {
            var profile = Hypixel.SkyblockProfile(_skyblockId);
            for (int i = 0; i < _users.Count; i++)
            {
                var member = profile["profile"]["members"][_users[i].UserId];
                _users[i].Update(member);
            }
        }

        public IEnumerator<ProfileUser> GetEnumerator()
        {
            return _users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}