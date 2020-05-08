using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace HypixelSkybot
{
    public partial class Banking
    {
        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }
    }

    public partial class Transaction
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("initiator_name")]
        public string InitiatorName { get; set; }
    }
    
    public partial class Profile
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("profile")]
        public ProfileClass ProfileProfile { get; set; }
    }

    public partial class ProfileClass
    {
        [JsonProperty("profile_id")]
        public string ProfileId { get; set; }

        [JsonProperty("members")]
        public Members Members { get; set; }
        
        [JsonProperty("banking")]
        public Banking Banking { get; set; }
    }

    public partial class Members
    {
        [JsonProperty("cc667c8121b34d8396eb283add51d416")]
        public Member Derf14 { get; set; }
        [JsonProperty("5f1e50718f9946a787eda89b772e6ecc")]
        public Member FrederikJa { get; set; }
    }

    public partial class Member
    {
        [JsonProperty("last_save")]
        public long LastSave { get; set; }

        [JsonProperty("inv_armor")]
        public FishingBag InvArmor { get; set; }

        [JsonProperty("coop_invitation")]
        public CoopInvitation CoopInvitation { get; set; }

        [JsonProperty("first_join")]
        public long FirstJoin { get; set; }

        [JsonProperty("first_join_hub")]
        public long FirstJoinHub { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, double> Stats { get; set; }

        [JsonProperty("objectives")]
        public Objectives Objectives { get; set; }

        [JsonProperty("tutorial")]
        public string[] Tutorial { get; set; }

        [JsonProperty("quests")]
        public Dictionary<string, Quest> Quests { get; set; }

        [JsonProperty("coin_purse")]
        public long CoinPurse { get; set; }

        [JsonProperty("last_death")]
        public long LastDeath { get; set; }

        [JsonProperty("crafted_generators")]
        public string[] CraftedGenerators { get; set; }

        [JsonProperty("fairy_souls_collected")]
        public long FairySoulsCollected { get; set; }

        [JsonProperty("fairy_souls")]
        public long FairySouls { get; set; }

        [JsonProperty("fairy_exchanges")]
        public long FairyExchanges { get; set; }

        [JsonProperty("fishing_treasure_caught")]
        public long FishingTreasureCaught { get; set; }

        [JsonProperty("death_count")]
        public long DeathCount { get; set; }

        [JsonProperty("achievement_spawned_island_types")]
        public string[] AchievementSpawnedIslandTypes { get; set; }

        [JsonProperty("slayer_quest")]
        public SlayerQuest SlayerQuest { get; set; }

        [JsonProperty("slayer_bosses")]
        public SlayerBosses SlayerBosses { get; set; }

        [JsonProperty("pets")]
        public Pet[] Pets { get; set; }

        [JsonProperty("experience_skill_runecrafting")]
        public double ExperienceSkillRunecrafting { get; set; }

        [JsonProperty("experience_skill_combat")]
        public double ExperienceSkillCombat { get; set; }

        [JsonProperty("experience_skill_mining")]
        public double ExperienceSkillMining { get; set; }

        [JsonProperty("unlocked_coll_tiers")]
        public string[] UnlockedCollTiers { get; set; }

        [JsonProperty("fishing_bag")]
        public FishingBag FishingBag { get; set; }

        [JsonProperty("experience_skill_alchemy")]
        public double ExperienceSkillAlchemy { get; set; }

        [JsonProperty("experience_skill_farming")]
        public double ExperienceSkillFarming { get; set; }

        [JsonProperty("collection")]
        public Dictionary<string, long> Collection { get; set; }

        [JsonProperty("quiver")]
        public FishingBag Quiver { get; set; }

        [JsonProperty("experience_skill_carpentry")]
        public double ExperienceSkillCarpentry { get; set; }
    }

    public partial class CoopInvitation
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("invited_by")]
        public string InvitedBy { get; set; }

        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }

        [JsonProperty("confirmed_timestamp")]
        public long ConfirmedTimestamp { get; set; }
    }

    public partial class FishingBag
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public partial class Objectives
    {
        [JsonProperty("collect_log")]
        public ChopTree CollectLog { get; set; }

        [JsonProperty("talk_to_guide")]
        public ChopTree TalkToGuide { get; set; }

        [JsonProperty("public_island")]
        public ChopTree PublicIsland { get; set; }

        [JsonProperty("craft_workbench")]
        public ChopTree CraftWorkbench { get; set; }

        [JsonProperty("explore_hub")]
        public ChopTree ExploreHub { get; set; }

        [JsonProperty("explore_village")]
        public ChopTree ExploreVillage { get; set; }

        [JsonProperty("talk_to_librarian")]
        public ChopTree TalkToLibrarian { get; set; }

        [JsonProperty("talk_to_farmer")]
        public ChopTree TalkToFarmer { get; set; }

        [JsonProperty("talk_to_blacksmith")]
        public ChopTree TalkToBlacksmith { get; set; }

        [JsonProperty("talk_to_lumberjack")]
        public ChopTree TalkToLumberjack { get; set; }

        [JsonProperty("talk_to_event_master")]
        public ChopTree TalkToEventMaster { get; set; }

        [JsonProperty("talk_to_auction_master")]
        public ChopTree TalkToAuctionMaster { get; set; }

        [JsonProperty("talk_to_banker")]
        public ChopTree TalkToBanker { get; set; }

        [JsonProperty("talk_to_fairy")]
        public ChopTree TalkToFairy { get; set; }

        [JsonProperty("talk_to_fisherman_1")]
        public ChopTree TalkToFisherman1 { get; set; }

        [JsonProperty("talk_to_carpenter")]
        public ChopTree TalkToCarpenter { get; set; }

        [JsonProperty("paint_canvas")]
        public ChopTree PaintCanvas { get; set; }

        [JsonProperty("talk_to_lazy_miner")]
        public ChopTree TalkToLazyMiner { get; set; }

        [JsonProperty("increase_mining_skill_5")]
        public ChopTree IncreaseMiningSkill5 { get; set; }

        [JsonProperty("talk_to_telekinesis_applier")]
        public ChopTree TalkToTelekinesisApplier { get; set; }

        [JsonProperty("find_pickaxe")]
        public ChopTree FindPickaxe { get; set; }

        [JsonProperty("collect_ingots")]
        public CollectIngots CollectIngots { get; set; }

        [JsonProperty("warp_deep_caverns")]
        public ChopTree WarpDeepCaverns { get; set; }

        [JsonProperty("talk_to_lapis_miner")]
        public ChopTree TalkToLapisMiner { get; set; }

        [JsonProperty("talk_to_lift_operator")]
        public ChopTree TalkToLiftOperator { get; set; }

        [JsonProperty("chop_tree")]
        public ChopTree ChopTree { get; set; }

        [JsonProperty("talk_to_lumberjack_2")]
        public ChopTree TalkToLumberjack2 { get; set; }

        [JsonProperty("increase_foraging_skill")]
        public ChopTree IncreaseForagingSkill { get; set; }

        [JsonProperty("warp_foraging_islands")]
        public ChopTree WarpForagingIslands { get; set; }

        [JsonProperty("reach_lapis_quarry")]
        public ChopTree ReachLapisQuarry { get; set; }

        [JsonProperty("collect_lapis")]
        public ChopTree CollectLapis { get; set; }

        [JsonProperty("give_pickaxe_lapis_miner")]
        public ChopTree GivePickaxeLapisMiner { get; set; }

        [JsonProperty("deposit_coins")]
        public ChopTree DepositCoins { get; set; }

        [JsonProperty("reach_pigmens_den")]
        public ChopTree ReachPigmensDen { get; set; }

        [JsonProperty("collect_redstone")]
        public ChopTree CollectRedstone { get; set; }

        [JsonProperty("reach_slimehill")]
        public ChopTree ReachSlimehill { get; set; }

        [JsonProperty("collect_emerald")]
        public ChopTree CollectEmerald { get; set; }

        [JsonProperty("reach_diamond_reserve")]
        public ChopTree ReachDiamondReserve { get; set; }

        [JsonProperty("collect_diamond")]
        public ChopTree CollectDiamond { get; set; }

        [JsonProperty("reach_obsidian_sanctuary")]
        public ChopTree ReachObsidianSanctuary { get; set; }

        [JsonProperty("collect_obsidian")]
        public ChopTree CollectObsidian { get; set; }

        [JsonProperty("talk_to_farmhand_1")]
        public ChopTree TalkToFarmhand1 { get; set; }

        [JsonProperty("increase_farming_skill_5")]
        public ChopTree IncreaseFarmingSkill5 { get; set; }

        [JsonProperty("craft_wheat_minion")]
        public ChopTree CraftWheatMinion { get; set; }

        [JsonProperty("warp_mushroom_desert")]
        public ChopTree WarpMushroomDesert { get; set; }

        [JsonProperty("collect_farming_resources_2")]
        public ChopTree CollectFarmingResources2 { get; set; }

        [JsonProperty("mine_coal")]
        public ChopTree MineCoal { get; set; }

        [JsonProperty("talk_to_blacksmith_2")]
        public ChopTree TalkToBlacksmith2 { get; set; }

        [JsonProperty("increase_mining_skill")]
        public ChopTree IncreaseMiningSkill { get; set; }

        [JsonProperty("reforge_item")]
        public ChopTree ReforgeItem { get; set; }

        [JsonProperty("warp_gold_mine")]
        public ChopTree WarpGoldMine { get; set; }

        [JsonProperty("talk_to_artist_1")]
        public ChopTree TalkToArtist1 { get; set; }

        [JsonProperty("increase_foraging_skill_5")]
        public ChopTree IncreaseForagingSkill5 { get; set; }

        [JsonProperty("talk_to_gustave_1")]
        public ChopTree TalkToGustave1 { get; set; }

        [JsonProperty("collect_birch_logs")]
        public ChopTree CollectBirchLogs { get; set; }

        [JsonProperty("collect_dark_oak_logs")]
        public ChopTree CollectDarkOakLogs { get; set; }

        [JsonProperty("talk_to_charlie")]
        public ChopTree TalkToCharlie { get; set; }

        [JsonProperty("increase_combat_skill_5")]
        public ChopTree IncreaseCombatSkill5 { get; set; }

        [JsonProperty("talk_to_rick")]
        public ChopTree TalkToRick { get; set; }

        [JsonProperty("warp_the_end")]
        public ChopTree WarpTheEnd { get; set; }

        [JsonProperty("warp_blazing_fortress")]
        public ChopTree WarpBlazingFortress { get; set; }

        [JsonProperty("kill_danger_mobs")]
        public ChopTree KillDangerMobs { get; set; }

        [JsonProperty("talk_to_bartender")]
        public ChopTree TalkToBartender { get; set; }

        [JsonProperty("increase_combat_skill")]
        public ChopTree IncreaseCombatSkill { get; set; }

        [JsonProperty("warp_spiders_den")]
        public ChopTree WarpSpidersDen { get; set; }

        [JsonProperty("talk_to_haymitch")]
        public ChopTree TalkToHaymitch { get; set; }

        [JsonProperty("talk_to_guber_1")]
        public ChopTree TalkToGuber1 { get; set; }

        [JsonProperty("talk_to_end_dealer")]
        public ChopTree TalkToEndDealer { get; set; }

        [JsonProperty("collect_end_stone")]
        public ChopTree CollectEndStone { get; set; }

        [JsonProperty("reach_dragons_nest")]
        public ChopTree ReachDragonsNest { get; set; }

        [JsonProperty("fight_dragon")]
        public ChopTree FightDragon { get; set; }

        [JsonProperty("talk_to_elle")]
        public ChopTree TalkToElle { get; set; }

        [JsonProperty("collect_nether_resources")]
        public CollectNetherResources CollectNetherResources { get; set; }

        [JsonProperty("collect_nether_resources_2")]
        public ChopTree CollectNetherResources2 { get; set; }

        [JsonProperty("talk_to_artist_2")]
        public ChopTree TalkToArtist2 { get; set; }

        [JsonProperty("give_fairy_souls")]
        public ChopTree GiveFairySouls { get; set; }

        [JsonProperty("collect_clay")]
        public ChopTree CollectClay { get; set; }

        [JsonProperty("talk_to_fisherman_2")]
        public ChopTree TalkToFisherman2 { get; set; }

        [JsonProperty("enchant_item")]
        public ChopTree EnchantItem { get; set; }

        [JsonProperty("complete_the_end_race_1")]
        public ChopTree CompleteTheEndRace1 { get; set; }

        [JsonProperty("talk_to_guber_2")]
        public ChopTree TalkToGuber2 { get; set; }

        [JsonProperty("complete_the_end_race_2")]
        public ChopTree CompleteTheEndRace2 { get; set; }

        [JsonProperty("talk_to_guber_3")]
        public ChopTree TalkToGuber3 { get; set; }

        [JsonProperty("complete_the_end_race_3")]
        public ChopTree CompleteTheEndRace3 { get; set; }

        [JsonProperty("talk_to_charlie_2")]
        public ChopTree TalkToCharlie2 { get; set; }

        [JsonProperty("talk_to_melody")]
        public ChopTree TalkToMelody { get; set; }

        [JsonProperty("complete_the_woods_race_1")]
        public ChopTree CompleteTheWoodsRace1 { get; set; }

        [JsonProperty("talk_to_gustave_2")]
        public ChopTree TalkToGustave2 { get; set; }

        [JsonProperty("complete_the_woods_race_2")]
        public ChopTree CompleteTheWoodsRace2 { get; set; }

        [JsonProperty("talk_to_gustave_3")]
        public ChopTree TalkToGustave3 { get; set; }

        [JsonProperty("complete_the_woods_race_3")]
        public ChopTree CompleteTheWoodsRace3 { get; set; }

        [JsonProperty("collect_spider")]
        public CollectSpider CollectSpider { get; set; }

        [JsonProperty("talk_to_guber_4")]
        public ChopTree TalkToGuber4 { get; set; }

        [JsonProperty("complete_the_end_race_4")]
        public ChopTree CompleteTheEndRace4 { get; set; }

        [JsonProperty("talk_to_frosty")]
        public ChopTree TalkToFrosty { get; set; }

        [JsonProperty("talk_to_gulliver_1")]
        public ChopTree TalkToGulliver1 { get; set; }

        [JsonProperty("complete_the_chicken_race_1")]
        public ChopTree CompleteTheChickenRace1 { get; set; }

        [JsonProperty("talk_to_gulliver_2")]
        public ChopTree TalkToGulliver2 { get; set; }

        [JsonProperty("complete_the_chicken_race_2")]
        public ChopTree CompleteTheChickenRace2 { get; set; }

        [JsonProperty("talk_to_gulliver_3")]
        public ChopTree TalkToGulliver3 { get; set; }

        [JsonProperty("complete_the_chicken_race_3")]
        public ChopTree CompleteTheChickenRace3 { get; set; }

        [JsonProperty("talk_to_gulliver_4")]
        public ChopTree TalkToGulliver4 { get; set; }

        [JsonProperty("complete_the_chicken_race_4")]
        public ChopTree CompleteTheChickenRace4 { get; set; }

        [JsonProperty("talk_to_gulliver_5")]
        public ChopTree TalkToGulliver5 { get; set; }

        [JsonProperty("give_rick_ingots")]
        public ChopTree GiveRickIngots { get; set; }

        [JsonProperty("craft_wood_pickaxe")]
        public ChopTree CraftWoodPickaxe { get; set; }

        [JsonProperty("talk_to_gustave_4")]
        public ChopTree TalkToGustave4 { get; set; }

        [JsonProperty("complete_the_woods_race_4")]
        public ChopTree CompleteTheWoodsRace4 { get; set; }

        [JsonProperty("talk_to_guber_5")]
        public ChopTree TalkToGuber5 { get; set; }

        [JsonProperty("collect_wool_carpenter")]
        public ChopTree CollectWoolCarpenter { get; set; }

        [JsonProperty("talk_to_pet_collector")]
        public ChopTree TalkToPetCollector { get; set; }

        [JsonProperty("talk_to_pet_sitter")]
        public ChopTree TalkToPetSitter { get; set; }
    }

    public partial class ChopTree
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("progress")]
        public long Progress { get; set; }

        [JsonProperty("completed_at")]
        public long CompletedAt { get; set; }

        [JsonProperty("DIAMOND", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Diamond { get; set; }

        [JsonProperty("EMERALD", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emerald { get; set; }

        [JsonProperty("ENDER_STONE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnderStone { get; set; }

        [JsonProperty("INK_SACK:4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InkSack4 { get; set; }

        [JsonProperty("OBSIDIAN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Obsidian { get; set; }

        [JsonProperty("REDSTONE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Redstone { get; set; }
    }

    public partial class CollectIngots
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("progress")]
        public long Progress { get; set; }

        [JsonProperty("completed_at")]
        public long CompletedAt { get; set; }

        [JsonProperty("GOLD_INGOT")]
        public bool GoldIngot { get; set; }

        [JsonProperty("IRON_INGOT")]
        public bool IronIngot { get; set; }
    }

    public partial class CollectNetherResources
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("progress")]
        public long Progress { get; set; }

        [JsonProperty("completed_at")]
        public long CompletedAt { get; set; }

        [JsonProperty("BLAZE_ROD")]
        public bool BlazeRod { get; set; }

        [JsonProperty("NETHER_STALK")]
        public bool NetherStalk { get; set; }
    }

    public partial class CollectSpider
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("progress")]
        public long Progress { get; set; }

        [JsonProperty("completed_at")]
        public long CompletedAt { get; set; }

        [JsonProperty("STRING")]
        public bool String { get; set; }

        [JsonProperty("SPIDER_EYE")]
        public bool SpiderEye { get; set; }
    }

    public partial class Pet
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("exp")]
        public double Exp { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("heldItem")]
        public string HeldItem { get; set; }

        [JsonProperty("candyUsed")]
        public long CandyUsed { get; set; }
    }

    public partial class Quest
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("activated_at")]
        public long ActivatedAt { get; set; }

        [JsonProperty("activated_at_sb")]
        public long ActivatedAtSb { get; set; }

        [JsonProperty("completed_at")]
        public long CompletedAt { get; set; }

        [JsonProperty("completed_at_sb")]
        public long CompletedAtSb { get; set; }
    }

    public partial class SlayerBosses
    {
        [JsonProperty("spider")]
        public Spider Spider { get; set; }

        [JsonProperty("wolf")]
        public Spider Wolf { get; set; }

        [JsonProperty("zombie")]
        public Spider Zombie { get; set; }
    }

    public partial class Spider
    {
        [JsonProperty("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonProperty("boss_kills_tier_0")]
        public long BossKillsTier0 { get; set; }

        [JsonProperty("xp")]
        public long Xp { get; set; }

        [JsonProperty("boss_kills_tier_1")]
        public long BossKillsTier1 { get; set; }

        [JsonProperty("boss_kills_tier_2")]
        public long BossKillsTier2 { get; set; }
    }

    public partial class ClaimedLevels
    {
        [JsonProperty("level_1")]
        public bool Level1 { get; set; }

        [JsonProperty("level_2")]
        public bool Level2 { get; set; }

        [JsonProperty("level_3")]
        public bool Level3 { get; set; }

        [JsonProperty("level_4")]
        public bool Level4 { get; set; }

        [JsonProperty("level_5", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Level5 { get; set; }
    }

    public partial class SlayerQuest
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tier")]
        public long Tier { get; set; }

        [JsonProperty("start_timestamp")]
        public long StartTimestamp { get; set; }

        [JsonProperty("completion_state")]
        public long CompletionState { get; set; }

        [JsonProperty("combat_xp")]
        public long CombatXp { get; set; }

        [JsonProperty("recent_mob_kills")]
        public RecentMobKill[] RecentMobKills { get; set; }

        [JsonProperty("last_killed_mob_island")]
        public string LastKilledMobIsland { get; set; }

        [JsonProperty("xp_on_last_follower_spawn")]
        public long XpOnLastFollowerSpawn { get; set; }

        [JsonProperty("spawn_timestamp")]
        public long SpawnTimestamp { get; set; }

        [JsonProperty("kill_timestamp")]
        public long KillTimestamp { get; set; }
    }

    public partial class RecentMobKill
    {
        [JsonProperty("xp")]
        public double Xp { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }

    public enum Status { Actie, Active, Complete };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ACTIE":
                    return Status.Actie;
                case "ACTIVE":
                    return Status.Active;
                case "COMPLETE":
                    return Status.Complete;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.Actie:
                    serializer.Serialize(writer, "ACTIE");
                    return;
                case Status.Active:
                    serializer.Serialize(writer, "ACTIVE");
                    return;
                case Status.Complete:
                    serializer.Serialize(writer, "COMPLETE");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
    
}
