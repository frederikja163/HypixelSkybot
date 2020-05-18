using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HypixelSkybot
{
    public partial class Return
    {
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public Profile Profile { get; set; }
    }

    public partial class Banking
    {
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Balance { get; set; }

        [JsonProperty("transactions", NullValueHandling = NullValueHandling.Ignore)]
        public Transaction[] Transactions { get; set; }
    }

    public partial class Transaction
    {
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        [JsonProperty("initiator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InitiatorName { get; set; }
    }

    public partial class Profile
    {
        [JsonProperty("profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileId { get; set; }

        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Member> Members { get; set; }

        [JsonProperty("banking", NullValueHandling = NullValueHandling.Ignore)]
        public Banking Banking { get; set; }
    }

    public partial class Member
    {
        [JsonProperty("last_save", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastSave { get; set; }

        [JsonProperty("inv_armor", NullValueHandling = NullValueHandling.Ignore)]
        public FishingBag InvArmor { get; set; }

        [JsonProperty("coop_invitation", NullValueHandling = NullValueHandling.Ignore)]
        public CoopInvitation CoopInvitation { get; set; }

        [JsonProperty("first_join", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstJoin { get; set; }

        [JsonProperty("first_join_hub", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstJoinHub { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> Stats { get; set; }

        [JsonProperty("objectives", NullValueHandling = NullValueHandling.Ignore)]
        public Objectives Objectives { get; set; }

        [JsonProperty("tutorial", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tutorial { get; set; }

        [JsonProperty("quests", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Quest> Quests { get; set; }

        [JsonProperty("coin_purse", NullValueHandling = NullValueHandling.Ignore)]
        public long? CoinPurse { get; set; }

        [JsonProperty("last_death", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastDeath { get; set; }

        [JsonProperty("crafted_generators", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CraftedGenerators { get; set; }

        [JsonProperty("fairy_souls_collected", NullValueHandling = NullValueHandling.Ignore)]
        public long? FairySoulsCollected { get; set; }

        [JsonProperty("fairy_souls", NullValueHandling = NullValueHandling.Ignore)]
        public long? FairySouls { get; set; }

        [JsonProperty("fairy_exchanges", NullValueHandling = NullValueHandling.Ignore)]
        public long? FairyExchanges { get; set; }

        [JsonProperty("fishing_treasure_caught", NullValueHandling = NullValueHandling.Ignore)]
        public long? FishingTreasureCaught { get; set; }

        [JsonProperty("death_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeathCount { get; set; }

        [JsonProperty("achievement_spawned_island_types", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AchievementSpawnedIslandTypes { get; set; }

        [JsonProperty("slayer_quest", NullValueHandling = NullValueHandling.Ignore)]
        public SlayerQuest SlayerQuest { get; set; }

        [JsonProperty("slayer_bosses", NullValueHandling = NullValueHandling.Ignore)]
        public SlayerBosses SlayerBosses { get; set; }

        [JsonProperty("pets", NullValueHandling = NullValueHandling.Ignore)]
        public Pet[] Pets { get; set; }

        [JsonProperty("experience_skill_runecrafting", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExperienceSkillRunecrafting { get; set; }

        [JsonProperty("experience_skill_combat", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExperienceSkillCombat { get; set; }

        [JsonProperty("experience_skill_mining", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExperienceSkillMining { get; set; }

        [JsonProperty("unlocked_coll_tiers", NullValueHandling = NullValueHandling.Ignore)]
        public string[] UnlockedCollTiers { get; set; }

        [JsonProperty("fishing_bag", NullValueHandling = NullValueHandling.Ignore)]
        public FishingBag FishingBag { get; set; }

        [JsonProperty("experience_skill_alchemy", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExperienceSkillAlchemy { get; set; }

        [JsonProperty("experience_skill_farming", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExperienceSkillFarming { get; set; }

        [JsonProperty("collection", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> Collection { get; set; }

        [JsonProperty("quiver", NullValueHandling = NullValueHandling.Ignore)]
        public FishingBag Quiver { get; set; }

        [JsonProperty("experience_skill_carpentry", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExperienceSkillCarpentry { get; set; }
    }

    public partial class CoopInvitation
    {
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        [JsonProperty("invited_by", NullValueHandling = NullValueHandling.Ignore)]
        public string InvitedBy { get; set; }

        [JsonProperty("confirmed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Confirmed { get; set; }

        [JsonProperty("confirmed_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConfirmedTimestamp { get; set; }
    }

    public partial class FishingBag
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }
    }

    public partial class Objectives
    {
        [JsonProperty("collect_log", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectLog { get; set; }

        [JsonProperty("talk_to_guide", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGuide { get; set; }

        [JsonProperty("public_island", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree PublicIsland { get; set; }

        [JsonProperty("craft_workbench", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CraftWorkbench { get; set; }

        [JsonProperty("explore_hub", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ExploreHub { get; set; }

        [JsonProperty("explore_village", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ExploreVillage { get; set; }

        [JsonProperty("talk_to_librarian", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToLibrarian { get; set; }

        [JsonProperty("talk_to_farmer", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToFarmer { get; set; }

        [JsonProperty("talk_to_blacksmith", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToBlacksmith { get; set; }

        [JsonProperty("talk_to_lumberjack", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToLumberjack { get; set; }

        [JsonProperty("talk_to_event_master", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToEventMaster { get; set; }

        [JsonProperty("talk_to_auction_master", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToAuctionMaster { get; set; }

        [JsonProperty("talk_to_banker", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToBanker { get; set; }

        [JsonProperty("talk_to_fairy", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToFairy { get; set; }

        [JsonProperty("talk_to_fisherman_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToFisherman1 { get; set; }

        [JsonProperty("talk_to_carpenter", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToCarpenter { get; set; }

        [JsonProperty("paint_canvas", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree PaintCanvas { get; set; }

        [JsonProperty("talk_to_lazy_miner", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToLazyMiner { get; set; }

        [JsonProperty("increase_mining_skill_5", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree IncreaseMiningSkill5 { get; set; }

        [JsonProperty("talk_to_telekinesis_applier", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToTelekinesisApplier { get; set; }

        [JsonProperty("find_pickaxe", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree FindPickaxe { get; set; }

        [JsonProperty("collect_ingots", NullValueHandling = NullValueHandling.Ignore)]
        public CollectIngots CollectIngots { get; set; }

        [JsonProperty("warp_deep_caverns", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree WarpDeepCaverns { get; set; }

        [JsonProperty("talk_to_lapis_miner", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToLapisMiner { get; set; }

        [JsonProperty("talk_to_lift_operator", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToLiftOperator { get; set; }

        [JsonProperty("chop_tree", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ChopTree { get; set; }

        [JsonProperty("talk_to_lumberjack_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToLumberjack2 { get; set; }

        [JsonProperty("increase_foraging_skill", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree IncreaseForagingSkill { get; set; }

        [JsonProperty("warp_foraging_islands", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree WarpForagingIslands { get; set; }

        [JsonProperty("reach_lapis_quarry", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ReachLapisQuarry { get; set; }

        [JsonProperty("collect_lapis", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectLapis { get; set; }

        [JsonProperty("give_pickaxe_lapis_miner", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree GivePickaxeLapisMiner { get; set; }

        [JsonProperty("deposit_coins", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree DepositCoins { get; set; }

        [JsonProperty("reach_pigmens_den", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ReachPigmensDen { get; set; }

        [JsonProperty("collect_redstone", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectRedstone { get; set; }

        [JsonProperty("reach_slimehill", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ReachSlimehill { get; set; }

        [JsonProperty("collect_emerald", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectEmerald { get; set; }

        [JsonProperty("reach_diamond_reserve", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ReachDiamondReserve { get; set; }

        [JsonProperty("collect_diamond", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectDiamond { get; set; }

        [JsonProperty("reach_obsidian_sanctuary", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ReachObsidianSanctuary { get; set; }

        [JsonProperty("collect_obsidian", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectObsidian { get; set; }

        [JsonProperty("talk_to_farmhand_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToFarmhand1 { get; set; }

        [JsonProperty("increase_farming_skill_5", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree IncreaseFarmingSkill5 { get; set; }

        [JsonProperty("craft_wheat_minion", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CraftWheatMinion { get; set; }

        [JsonProperty("warp_mushroom_desert", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree WarpMushroomDesert { get; set; }

        [JsonProperty("collect_farming_resources_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectFarmingResources2 { get; set; }

        [JsonProperty("mine_coal", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree MineCoal { get; set; }

        [JsonProperty("talk_to_blacksmith_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToBlacksmith2 { get; set; }

        [JsonProperty("increase_mining_skill", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree IncreaseMiningSkill { get; set; }

        [JsonProperty("reforge_item", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ReforgeItem { get; set; }

        [JsonProperty("warp_gold_mine", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree WarpGoldMine { get; set; }

        [JsonProperty("talk_to_artist_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToArtist1 { get; set; }

        [JsonProperty("increase_foraging_skill_5", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree IncreaseForagingSkill5 { get; set; }

        [JsonProperty("talk_to_gustave_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGustave1 { get; set; }

        [JsonProperty("collect_birch_logs", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectBirchLogs { get; set; }

        [JsonProperty("collect_dark_oak_logs", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectDarkOakLogs { get; set; }

        [JsonProperty("talk_to_charlie", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToCharlie { get; set; }

        [JsonProperty("increase_combat_skill_5", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree IncreaseCombatSkill5 { get; set; }

        [JsonProperty("talk_to_rick", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToRick { get; set; }

        [JsonProperty("warp_the_end", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree WarpTheEnd { get; set; }

        [JsonProperty("warp_blazing_fortress", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree WarpBlazingFortress { get; set; }

        [JsonProperty("kill_danger_mobs", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree KillDangerMobs { get; set; }

        [JsonProperty("talk_to_bartender", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToBartender { get; set; }

        [JsonProperty("increase_combat_skill", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree IncreaseCombatSkill { get; set; }

        [JsonProperty("warp_spiders_den", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree WarpSpidersDen { get; set; }

        [JsonProperty("talk_to_haymitch", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToHaymitch { get; set; }

        [JsonProperty("talk_to_guber_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGuber1 { get; set; }

        [JsonProperty("talk_to_end_dealer", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToEndDealer { get; set; }

        [JsonProperty("collect_end_stone", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectEndStone { get; set; }

        [JsonProperty("reach_dragons_nest", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree ReachDragonsNest { get; set; }

        [JsonProperty("fight_dragon", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree FightDragon { get; set; }

        [JsonProperty("talk_to_elle", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToElle { get; set; }

        [JsonProperty("collect_nether_resources", NullValueHandling = NullValueHandling.Ignore)]
        public CollectNetherResources CollectNetherResources { get; set; }

        [JsonProperty("collect_nether_resources_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectNetherResources2 { get; set; }

        [JsonProperty("talk_to_artist_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToArtist2 { get; set; }

        [JsonProperty("give_fairy_souls", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree GiveFairySouls { get; set; }

        [JsonProperty("collect_clay", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectClay { get; set; }

        [JsonProperty("talk_to_fisherman_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToFisherman2 { get; set; }

        [JsonProperty("enchant_item", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree EnchantItem { get; set; }

        [JsonProperty("complete_the_end_race_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheEndRace1 { get; set; }

        [JsonProperty("talk_to_guber_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGuber2 { get; set; }

        [JsonProperty("complete_the_end_race_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheEndRace2 { get; set; }

        [JsonProperty("talk_to_guber_3", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGuber3 { get; set; }

        [JsonProperty("complete_the_end_race_3", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheEndRace3 { get; set; }

        [JsonProperty("talk_to_charlie_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToCharlie2 { get; set; }

        [JsonProperty("talk_to_melody", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToMelody { get; set; }

        [JsonProperty("complete_the_woods_race_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheWoodsRace1 { get; set; }

        [JsonProperty("talk_to_gustave_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGustave2 { get; set; }

        [JsonProperty("complete_the_woods_race_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheWoodsRace2 { get; set; }

        [JsonProperty("talk_to_gustave_3", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGustave3 { get; set; }

        [JsonProperty("complete_the_woods_race_3", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheWoodsRace3 { get; set; }

        [JsonProperty("collect_spider", NullValueHandling = NullValueHandling.Ignore)]
        public CollectSpider CollectSpider { get; set; }

        [JsonProperty("talk_to_guber_4", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGuber4 { get; set; }

        [JsonProperty("complete_the_end_race_4", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheEndRace4 { get; set; }

        [JsonProperty("talk_to_frosty", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToFrosty { get; set; }

        [JsonProperty("talk_to_gulliver_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGulliver1 { get; set; }

        [JsonProperty("complete_the_chicken_race_1", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheChickenRace1 { get; set; }

        [JsonProperty("talk_to_gulliver_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGulliver2 { get; set; }

        [JsonProperty("complete_the_chicken_race_2", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheChickenRace2 { get; set; }

        [JsonProperty("talk_to_gulliver_3", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGulliver3 { get; set; }

        [JsonProperty("complete_the_chicken_race_3", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheChickenRace3 { get; set; }

        [JsonProperty("talk_to_gulliver_4", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGulliver4 { get; set; }

        [JsonProperty("complete_the_chicken_race_4", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheChickenRace4 { get; set; }

        [JsonProperty("talk_to_gulliver_5", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGulliver5 { get; set; }

        [JsonProperty("give_rick_ingots", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree GiveRickIngots { get; set; }

        [JsonProperty("craft_wood_pickaxe", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CraftWoodPickaxe { get; set; }

        [JsonProperty("talk_to_gustave_4", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGustave4 { get; set; }

        [JsonProperty("complete_the_woods_race_4", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CompleteTheWoodsRace4 { get; set; }

        [JsonProperty("talk_to_guber_5", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToGuber5 { get; set; }

        [JsonProperty("collect_wool_carpenter", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree CollectWoolCarpenter { get; set; }

        [JsonProperty("talk_to_pet_collector", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToPetCollector { get; set; }

        [JsonProperty("talk_to_pet_sitter", NullValueHandling = NullValueHandling.Ignore)]
        public ChopTree TalkToPetSitter { get; set; }
    }

    public partial class ChopTree
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status? Status { get; set; }

        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public long? Progress { get; set; }

        [JsonProperty("completed_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletedAt { get; set; }

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
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status? Status { get; set; }

        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public long? Progress { get; set; }

        [JsonProperty("completed_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletedAt { get; set; }

        [JsonProperty("GOLD_INGOT", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GoldIngot { get; set; }

        [JsonProperty("IRON_INGOT", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IronIngot { get; set; }
    }

    public partial class CollectNetherResources
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status? Status { get; set; }

        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public long? Progress { get; set; }

        [JsonProperty("completed_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletedAt { get; set; }

        [JsonProperty("BLAZE_ROD", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BlazeRod { get; set; }

        [JsonProperty("NETHER_STALK", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NetherStalk { get; set; }
    }

    public partial class CollectSpider
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status? Status { get; set; }

        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public long? Progress { get; set; }

        [JsonProperty("completed_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletedAt { get; set; }

        [JsonProperty("STRING", NullValueHandling = NullValueHandling.Ignore)]
        public bool? String { get; set; }

        [JsonProperty("SPIDER_EYE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SpiderEye { get; set; }
    }

    public partial class Pet
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("exp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Exp { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("tier", NullValueHandling = NullValueHandling.Ignore)]
        public Tier? Tier { get; set; }

        [JsonProperty("heldItem")]
        public string HeldItem { get; set; }

        [JsonProperty("candyUsed", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyUsed { get; set; }
    }

    public partial class Quest
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status? Status { get; set; }

        [JsonProperty("activated_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActivatedAt { get; set; }

        [JsonProperty("activated_at_sb", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActivatedAtSb { get; set; }

        [JsonProperty("completed_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletedAt { get; set; }

        [JsonProperty("completed_at_sb", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletedAtSb { get; set; }
    }

    public partial class SlayerBosses
    {
        [JsonProperty("spider", NullValueHandling = NullValueHandling.Ignore)]
        public Spider Spider { get; set; }

        [JsonProperty("wolf", NullValueHandling = NullValueHandling.Ignore)]
        public Spider Wolf { get; set; }

        [JsonProperty("zombie", NullValueHandling = NullValueHandling.Ignore)]
        public Spider Zombie { get; set; }
    }

    public partial class Spider
    {
        [JsonProperty("claimed_levels", NullValueHandling = NullValueHandling.Ignore)]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonProperty("boss_kills_tier_0", NullValueHandling = NullValueHandling.Ignore)]
        public long? BossKillsTier0 { get; set; }

        [JsonProperty("xp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Xp { get; set; }

        [JsonProperty("boss_kills_tier_1", NullValueHandling = NullValueHandling.Ignore)]
        public long? BossKillsTier1 { get; set; }

        [JsonProperty("boss_kills_tier_2", NullValueHandling = NullValueHandling.Ignore)]
        public long? BossKillsTier2 { get; set; }
    }

    public partial class ClaimedLevels
    {
        [JsonProperty("level_1", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Level1 { get; set; }

        [JsonProperty("level_2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Level2 { get; set; }

        [JsonProperty("level_3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Level3 { get; set; }

        [JsonProperty("level_4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Level4 { get; set; }

        [JsonProperty("level_5", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Level5 { get; set; }
    }

    public partial class SlayerQuest
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("tier", NullValueHandling = NullValueHandling.Ignore)]
        public long? Tier { get; set; }

        [JsonProperty("start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTimestamp { get; set; }

        [JsonProperty("completion_state", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompletionState { get; set; }

        [JsonProperty("combat_xp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CombatXp { get; set; }

        [JsonProperty("recent_mob_kills", NullValueHandling = NullValueHandling.Ignore)]
        public RecentMobKill[] RecentMobKills { get; set; }

        [JsonProperty("last_killed_mob_island", NullValueHandling = NullValueHandling.Ignore)]
        public string LastKilledMobIsland { get; set; }

        [JsonProperty("xp_on_last_follower_spawn", NullValueHandling = NullValueHandling.Ignore)]
        public long? XpOnLastFollowerSpawn { get; set; }

        [JsonProperty("spawn_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? SpawnTimestamp { get; set; }

        [JsonProperty("kill_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? KillTimestamp { get; set; }
    }

    public partial class RecentMobKill
    {
        [JsonProperty("xp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Xp { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }
    }

    public enum Status { Actie, Active, Complete };

    public enum Tier { Common, Epic, Legendary };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                StatusConverter.Singleton,
                TierConverter.Singleton,
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

    internal class TierConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tier) || t == typeof(Tier?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "COMMON":
                    return Tier.Common;
                case "EPIC":
                    return Tier.Epic;
                case "LEGENDARY":
                    return Tier.Legendary;
            }
            throw new Exception("Cannot unmarshal type Tier");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Tier)untypedValue;
            switch (value)
            {
                case Tier.Common:
                    serializer.Serialize(writer, "COMMON");
                    return;
                case Tier.Epic:
                    serializer.Serialize(writer, "EPIC");
                    return;
                case Tier.Legendary:
                    serializer.Serialize(writer, "LEGENDARY");
                    return;
            }
            throw new Exception("Cannot marshal type Tier");
        }

        public static readonly TierConverter Singleton = new TierConverter();
    }
}
