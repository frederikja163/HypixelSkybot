using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace HypixelSkybot
{
    public enum LevelType
    {
        Alchemy = 0,
        Taming,
        Mining,
        Foraging,
        Enchanting,
        Carpentry,
        Farming,
        Combat,
        Fishing,
        Runecrafting,
        Revenant,
        Tarrantula,
        Wolf
    }
    
    public class Level
    {
        private class XpPerLevel
        {
            private readonly int[] _values;
            
            public int this[int i] => i <= 0 ? 0 : _values[(i - 1) % _values.Length];

            public int MaxLevel => _values.Length;

            private XpPerLevel(int[] values)
            {
                _values = values;
            }
            
            public static implicit operator XpPerLevel(int[] values) => new XpPerLevel(values);
        }
        
        private static ReadOnlyDictionary<XpType, XpPerLevel> _xpTypes= 
            new ReadOnlyDictionary<XpType, XpPerLevel>(new Dictionary<XpType, XpPerLevel>(new []
            {
                new KeyValuePair<XpType, XpPerLevel>(XpType.Skill, new[]{50,125,200,300,500,750,1000,1500,2000,3500,5000,7500,10000,15000,20000,30000,50000,75000,100000,200000,300000,400000,500000,600000,700000,800000,900000,1000000,1100000,1200000,1300000,1400000,1500000,1600000,1700000,1800000,1900000,2000000,2100000,2200000,2300000,2400000,2500000,2600000,2700000,2800000,3100000,3400000,3700000,4000000}),
                new KeyValuePair<XpType, XpPerLevel>(XpType.Runecrafting, new[]{50, 100, 125, 160, 200, 250, 315, 400, 500, 625, 785, 1000, 1250, 1600, 2000, 2465, 3125, 4000, 5000, 6200, 7800, 9800, 12200, 15300}),
                new KeyValuePair<XpType, XpPerLevel>(XpType.Slayer, new[]{5, 15, 200, 1000, 5000, 20000, 100000, 400000}),

            }));
        // private static readonly int[] SkillXpPerLevel =
        // {
        //     50,125,200,300,500,750,1000,1500,2000,3500,5000,7500,10000,15000,20000,30000,50000,75000,100000,200000,300000,400000,500000,600000,700000,800000,900000,1000000,1100000,1200000,1300000,1400000,1500000,1600000,1700000,1800000,1900000,2000000,2100000,2200000,2300000,2400000,2500000,2600000,2700000,2800000,3100000,3400000,3700000,4000000
        // };
        //
        // private static readonly int[] RunecraftingXpPerLevel =
        // {
        //     50, 100, 125, 160, 200, 250, 315, 400, 500, 625, 785, 1000, 1250, 1600, 2000, 2465, 3125, 4000, 5000, 6200, 7800, 9800, 12200, 15300
        // };
        //
        // private static readonly int[] SlayerXpPerLevel =
        // {
        //     5, 15, 200, 1000, 5000, 20000, 100000, 400000
        // };
        
        private enum XpType
        {
            Runecrafting,
            Slayer,
            Skill
        }

        private readonly XpPerLevel _xpPerLevel;
        
        public LevelType type { get; }
        private int _xp;

        public int Xp
        {
            get => _xp;
            set
            {
                _xp = value;

                CurrentLevel = 0;
                while (CurrentLevel < _xpPerLevel.MaxLevel && _xp >= _xpPerLevel[CurrentLevel])
                {
                    _xp -= _xpPerLevel[CurrentLevel++];
                }
                CurrentLevel--;
            }
        }

        public int CurrentLevel { get; private set; } = 0;

        public int MaxLevel => _xpPerLevel.MaxLevel;
        
        public int XpForLevelup => _xpPerLevel[CurrentLevel + 1];

        public Level(LevelType levelType, int xp)
        {
            var type = LevelTypeToXpType(levelType);
            _xpTypes.TryGetValue(type, out _xpPerLevel);
            Xp = xp;
            this.type = levelType;
        }

        public static string[] LevelTypeToJsonPath(LevelType type) => type switch
        {
            LevelType.Alchemy => new[] {"experience_skill_alchemy"},
            LevelType.Taming => new[] {"experience_skill_taming"},
            LevelType.Mining => new[] {"experience_skill_mining"},
            LevelType.Foraging => new[] {"experience_skill_foraging"},
            LevelType.Enchanting => new[] {"experience_skill_enchanting"},
            LevelType.Carpentry => new[] {"experience_skill_carpentry"},
            LevelType.Farming => new[] {"experience_skill_farming"},
            LevelType.Combat => new[] {"experience_skill_combat"},
            LevelType.Fishing => new[] {"experience_skill_fishing"},
            LevelType.Runecrafting => new[] {"experience_skill_runecrafting"},
            LevelType.Revenant => new[] {"slayer_bosses", "zombie", "xp"},
            LevelType.Tarrantula => new[] {"slayer_bosses", "spider", "xp"},
            LevelType.Wolf => new[] {"slayer_bosses", "wolf", "xp"},
            _ => new string[0]
        };
        
        private static XpType LevelTypeToXpType(LevelType type) => type switch
        {
            LevelType.Alchemy => XpType.Skill,
            LevelType.Taming => XpType.Skill,
            LevelType.Mining => XpType.Skill,
            LevelType.Foraging => XpType.Skill,
            LevelType.Enchanting => XpType.Skill,
            LevelType.Carpentry => XpType.Skill,
            LevelType.Farming => XpType.Skill,
            LevelType.Combat => XpType.Skill,
            LevelType.Fishing => XpType.Skill,
            LevelType.Runecrafting => XpType.Runecrafting,
            LevelType.Revenant => XpType.Slayer,
            LevelType.Tarrantula => XpType.Slayer,
            LevelType.Wolf => XpType.Slayer,
            _ => (XpType)type
        };
    }
}