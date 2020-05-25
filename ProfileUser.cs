using System;
using Discord.WebSocket;
using HypixelSkybot.Extensions;
using Newtonsoft.Json.Linq;

namespace HypixelSkybot
{
    public class ProfileUser
    {
        public const string ZealotKills = "kills_zealot_enderman";
        public const string Deaths = "deaths";
        private JToken _last;
        private JToken _current;
        private Level[] _lastLevels;
        private Level[] _curLevels;
        private ISocketMessageChannel _channel;
        
        public string UserId { get; }
        public string Username { get; }

        public Level this[LevelType type] => _curLevels[(int) type];
        
        public ProfileUser(ISocketMessageChannel channel, string userId, string username)
        {
            _channel = channel;
            UserId = userId;
            Username = username;
            _curLevels = new Level[typeof(LevelType).GetEnumNames().Length];
            _lastLevels = new Level[_curLevels.Length];
            for (uint i = 0; i < _curLevels.Length; i++)
            {
                _curLevels[i] = new Level((LevelType)i, 0);
            }
        }

        public void Update(JToken current)
        {
            _last = _current;
            _current = current;

            Array.Copy(_curLevels, _lastLevels, _curLevels.Length);
            for (uint i = 0; i < _curLevels.Length; i++)
            {
                _curLevels[i].Xp = (int)_current.GetValue<double>(Level.LevelTypeToJsonPath(_curLevels[i].type));
            }

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

            for (int i = 0; i < _curLevels.Length; i++)
            {
                if (_lastLevels[i].CurrentLevel < _curLevels[i].CurrentLevel)
                {
                    _channel.SendMessageAsync(
                        $"{Username} just levelled up in {_curLevels[i].type.ToString()} to level {_curLevels[i].CurrentLevel} good luck getting the {_curLevels[i].XpForLevelup} xp for the next level!");
                }
            }
        }

        public double GetCurrentStat(string stat)
        {
            var s = _current["stats"][stat];
            return (s == null) ? 0 : s.Value<double>();
        }
        private double GetLastStat(string stat)
        {
            var s = _last["stats"][stat];
            return (s == null) ? 0 : s.Value<double>();
        }
    }
}