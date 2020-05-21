using System;
using System.Collections.Generic;
using Discord.WebSocket;
using HypixelSkybot.Extensions;
using HypixelSkybot.SkyblockProfileReturn;
using Newtonsoft.Json.Linq;

namespace HypixelSkybot
{
    public class ProfileUser
    {
        public const string ZealotKills = "kills_zealot_enderman";
        public const string Deaths = "deaths";
        private JToken _last;
        private JToken _current;
        private ISocketMessageChannel _channel;
        
        public string UserId { get; }
        public string Username { get; }
        
        public ProfileUser(ISocketMessageChannel channel, string userId, string username)
        {
            _channel = channel;
            UserId = userId;
            Username = username;
        }

        public void Update(JToken current)
        {
            _last = _current;
            _current = current;

            if (_last == null)
            {
                return;
            }

            if (Math.Floor(GetCurrentStat(ZealotKills) / 1000) > Math.Floor(GetLastStat(ZealotKills) / 1000))
            {
                _channel.SendMessageAsync(
                    $"{Username} has killed more than {Math.Floor(GetCurrentStat(ZealotKills) / 1000)}000 zealots!");
            }

            if (GetCurrentStat(Deaths) >= GetLastStat(Deaths))
            {
                foreach (var stat in _current["stats"])
                {
                    if (stat.Path.Contains($"{Deaths}_"))
                    {
                        var statName = stat.Name();
                        if (GetCurrentStat(statName) > GetLastStat(statName))
                        {
                            _channel.SendMessageAsync(
                                $"{Username} just died to {statName.Substring(Deaths.Length + 1)}");
                            break;
                        }
                    }
                }
            }
        }

        public double GetCurrentStat(string stat)
        {
            return _current["stats"][stat].Value<double>();
        }
        private double GetLastStat(string stat)
        {
            return _last["stats"][stat].Value<double>();
        }
    }
}