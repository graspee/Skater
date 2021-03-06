﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Tilestuff
{


    public static readonly string[] tilestring =
    {
     "//FLOODTEMP",
    "//EMPTY",
    "//THEREISNTAZERO",
    "//NOSPRITE",
    "Pango Pangolin",
    "Reginald Marsby",
    "Papa Greebo",
    "Polarmoop",
    "Frenzly Wolf",
    "Wolf Skellington",
    "Dead Wolf",
    "Muhkittenz, ginger",
    "Dead Muhkittenz, ginger",
    "Muhkittenz, b/w",
    "Dead Muhkittenz, b/w",
    "Muhkittenz, British Blue",
    "Dead Muhkittenz, British Blue",
    "Muhkittenz, black",
    "Dead Muhkittenz, black",
    "Muhkittenz Skellington",
    "Enemy Polarmoop",
    "Dead Enemy Polarmoop",
    "Enemy Polarmoop skellington",
    "Human Skellington",
    "Ice golem",
    "Kobby bomber",
    "Dead Kobby bomber",
    "Kobby skellington",
    "Giant bat",
    "Dead giant bat",
    "Giant bat skellington",
    "Ice mage",
    "Ice mage (casting)",
    "Dead ice mage",
    "Necromancer",
    "Necromancer (casting)",
    "Dead necromancer",
    "Lich",
    "Lich (casting)",
    "Anti-paladin",
    "Lancer",
    "Swinger",
    "Tef-rog",
    "//ENEMY_SKATER_BLANKSPRITE",
    "Dead enemy skater",
    "Sign: 'Thin Ice'",
    "Barrel",
    "Broken barrel",
    "Lantern on a stick for no reason",
    "Cairn (red)",
    "Cairn (green)",
    "Cairn (blue)",
    "Cairn (purple)",
    "Pile of stones (red cairn)",
    "Pile of stones (green cairn)",
    "Pile of stones (blue cairn)",
    "Pile of stones (purple cairn)",
    "Wizard wall",
    "Moopcrate (closed)",
    "Moopcrate (open)",
    "Raw meat",
    "Bomb",
    "Bomb (lit 1s)",
    "Bomb (lit 2s)",
    "Bomb (lit 3s)",
    "Bomb (lit 4s about to blow!)",
    "Trap (safe, to pick up and use)",
    "Trap (set)",
    "Trap (sprung)",
    "Scrool of Ice Cube",
    "Scrool of Fire Lance",
    "Potion of speed",
    "Potion of special",
    "A hopped-up fochs!",
    "A fochs skellington",
    "An echs-fochs",
    "Warp Beedz!",
    "Warp Gate",
    "Warp Gate",
    "Warp Gate",
    "//ITEM_WARP_GATE_RAYS_1",
    "//ITEM_WARP_GATE_RAYS_2",
    "//EFFECT_DIRECTION_INDICATOR_1",
    "//EFFECT_DIRECTION_INDICATOR_2",
    "//EFFECT_DIRECTION_INDICATOR_3",
    "//EFFECT_DIRECTION_INDICATOR_4",
    "//EFFECT_DIRECTION_INDICATOR_5",
    "//EFFECT_DIRECTION_INDICATOR_6",
    "//EFFECT_DIRECTION_INDICATOR_7",
    "//EFFECT_DIRECTION_INDICATOR_8",
    "//EFFECT_TARGETING_PURPLE_THING",
    "//EFFECT_BLOOD_1",
    "//EFFECT_BLOOD_2",
    "//EFFECT_BLOOD_3",
    "//EFFECT_BLOOD_4",
    "//EFFECT_BLOOD_CRIT_1",
    "//EFFECT_BLOOD_CRIT_2",
    "//EFFECT_BLOOD_CRIT_3",
    "//EFFECT_BLOOD_CRIT_4",
    "//EFFECT_PARTICLE_8X8_TOPLEFT_DRAIN_LIFE",
    "//EFFECT_PARTICLE_8X8_TOPLEFT_MAGES_ICE_BEAM",
    "//EFFECT_PARTICLE_8X8_TOPLEFT_SCROLL_FIRE_LANCE",
    "//EFFECT_PARTICLE_8X8_TOPLEFT_CAIRN_BEAM",
    "//EFFECT_PARTICLE_8X8_TOPLEFT_PANGO_TUNG",
    "//EFFECT_FIRE_ANIM_1",
    "//EFFECT_FIRE_ANIM_2",
    "//EFFECT_FIRE_ANIM_3",
    "[SNOW]",
    "[ICE]",
    "[THIN_ICE]",
    "[WATER]",
    "[SNOW-COVERED ROCK]",
    "[SNOW-COVERED ROCK]",
    "[SNOW-COVERED ROCK]",
    "[SNOW-COVERED ROCK]",
    "Tree",
    "Tree",
    "Tree",
    "Tree",
   "[STONE WALL]",
   "[STONE FLOOR]",
    "//ICON_ATTACK_UP",
    "//ICON_ATTACK_DOWN",
    "//ICON_DEFENSE_UP",
    "//ICON_DEFENSE_DOWN",
    "//ICON_BLEEDING",
    "//ICON_FREEZING",
    "//EFFECT_BLOCK_OF_ICE_FOR_SPELL",
    "//ICON_HASNT_SEEN_YOU",
    "MAXIM GUN",
    "//EFFECT_CRIT",
    "//EFFECT_CRIT_AT_AN_ANGLE",
    "//EFFECT_MUSICAL_NOTE",
    "//PARTICLE_SNOW_3X3",
    "//PARTICLE_SNOW_4X4",
    "//PARTICLE_SNOW_6X6",
    "[HENGE STONE]",
    "[HENGE STONE]",
    "[HENGE STONE]",
    "[HENGE STONE]",
    "//EFFECT_FULLSQUARE",
     "//COMBAT_GRID_ATTACK",
    "//COMBAT_GRID_DEFENCE",
    "//COMBAT_GRID_VULNERABLE",
    "//INVENTORY_HAND",
    "Fishing rod",
    "Fishy"
};
}
public enum Etilesprite : int
{
    FLOODTEMP = -2,
    EMPTY = -1,
    THEREISNTAZERO = 0,
    NOSPRITE = 1,
    PLAYER_PANGO_PANGOLIN,
    PLAYER_REGINALD_MARSBY,
    PLAYER_PAPA_GREEBO,
    PLAYER_POLARMOOP,
    PLAYER_COMPANION_WOLF,
    PLAYER_COMPANION_WOLF_SKELETON,
    PLAYER_COMPANION_WOLF_CORPSE,
    PLAYER_COMPANION_MUHKITTENS_GINGER,
    PLAYER_COMPANION_MUHKITTENS_GINGER_CORPSE,
    PLAYER_COMPANION_MUHKITTENS_BW,
    PLAYER_COMPANION_MUHKITTENS_BW_CORPSE,
    PLAYER_COMPANION_MUHKITTENS_BRITISHBLUE,
    PLAYER_COMPANION_MUHKITTENS_BRITISHBLUE_CORPSE,
    PLAYER_COMPANION_MUHKITTENS_BLACK,
    PLAYER_COMPANION_MUHKITTENS_BLACK_CORPSE,
    PLAYER_COMPANION_MUHKITTENS_SKELETON,
    ENEMY_POLARMOOP,
    ENEMY_POLARMOOP_CORPSE,
    ENEMY_POLARMOOP_SKELETON,
    ENEMY_HUMAN_SKELETON,
    ENEMY_ICE_GOLEM,
    ENEMY_KOBBY_BOMBER,
    ENEMY_KOBBY_BOMBER_CORPSE,
    ENEMY_KOBBY_BOMBER_SKELETON,
    ENEMY_GIANTBAT,
    ENEMY_GIANTBAT_CORPSE,
    ENEMY_GIANTBAT_SKELETON,
    ENEMY_MAGE,
    ENEMY_MAGE_CASTING,
    ENEMY_MAGE_CORPSE,
    ENEMY_NECROMANCER,
    ENEMY_NECROMANCER_CASTING,
    ENEMY_NECROMANCER_CORPSE,
    ENEMY_LICH,
    ENEMY_LICH_CASTING,
    ENEMY_SKATER_SWORDANDBOARD,
    ENEMY_SKATER_SPEAR,
    ENEMY_SKATER_CHAIN,
    ENEMY_SKATER_DAGGER,
    ENEMY_SKATER_BLANKSPRITE,
    ENEMY_SKATER_CORPSE,
    ITEM_SIGN_THIN_ICE,
    ITEM_BARREL,
    ITEM_BARREL_BROKEN,
    ITEM_LANTERN_ON_A_STICK_FOR_NO_REASON,
    ITEM_CAIRN_RED,
    ITEM_CAIRN_GREEN,
    ITEM_CAIRN_BLUE,
    ITEM_CAIRN_PURPLE,
    ITEM_CAIRN_USED_RED,
    ITEM_CAIRN_USED_GREEN,
    ITEM_CAIRN_USED_BLUE,
    ITEM_CAIRN_USED_PURPLE,
    ITEM_WIZARD_WALL,
    ITEM_MOOPCRATE_CLOSED,
    ITEM_MOOPCRATE_OPENED,
    ITEM_RAW_MEAT,
    ITEM_BOMB,
    ITEM_BOMB_LIT_1,
    ITEM_BOMB_LIT_2,
    ITEM_BOMB_LIT_3,
    ITEM_BOMB_LIT_4_ABOUT_TO_BLOW,
    ITEM_TRAP,
    ITEM_TRAP_SET,
    ITEM_TRAP_SPRUNG,
    ITEM_SCROLL_ICECUBE,
    ITEM_SCROLL_FIRELANCE,
    ITEM_POTION_SPEED,
    ITEM_POTION_SPECIAL,
    ENEMY_HOPPED_UP_FOX,
    ENEMY_HOPPED_UP_FOX_SKELETON,
    ENEMY_HOPPED_UP_FOX_CORPSE,
    ITEM_WARP_BEADS,
    ITEM_WARP_GATE_ANIM_1,
    ITEM_WARP_GATE_ANIM_2,
    ITEM_WARP_GATE_ANIM_3,
    ITEM_WARP_GATE_RAYS_1,
    ITEM_WARP_GATE_RAYS_2,
    EFFECT_DIRECTION_INDICATOR_1,
    EFFECT_DIRECTION_INDICATOR_2,
    EFFECT_DIRECTION_INDICATOR_3,
    EFFECT_DIRECTION_INDICATOR_4,
    EFFECT_DIRECTION_INDICATOR_5,
    EFFECT_DIRECTION_INDICATOR_6,
    EFFECT_DIRECTION_INDICATOR_7,
    EFFECT_DIRECTION_INDICATOR_8,
    EFFECT_TARGETING_PURPLE_THING,
    EFFECT_BLOOD_1,
    EFFECT_BLOOD_2,
    EFFECT_BLOOD_3,
    EFFECT_BLOOD_4,
    EFFECT_BLOOD_CRIT_1,
    EFFECT_BLOOD_CRIT_2,
    EFFECT_BLOOD_CRIT_3,
    EFFECT_BLOOD_CRIT_4,
    EFFECT_PARTICLE_8X8_TOPLEFT_DRAIN_LIFE,
    EFFECT_PARTICLE_8X8_TOPLEFT_MAGES_ICE_BEAM,
    EFFECT_PARTICLE_8X8_TOPLEFT_SCROLL_FIRE_LANCE,
    EFFECT_PARTICLE_8X8_TOPLEFT_CAIRN_BEAM,
    EFFECT_PARTICLE_8X8_TOPLEFT_PANGO_TUNG,
    EFFECT_FIRE_ANIM_1,
    EFFECT_FIRE_ANIM_2,
    EFFECT_FIRE_ANIM_3,
    MAP_SNOW,
    MAP_ICE,
    MAP_THIN_ICE,
    MAP_WATER,
    MAP_SNOW_COVERED_ROCK_1,
    MAP_SNOW_COVERED_ROCK_2,
    MAP_SNOW_COVERED_ROCK_3,
    MAP_SNOW_COVERED_ROCK_4,
    MAP_TREE_BARE_1,
    MAP_TREE_BARE_2,
    MAP_TREE_GREEN_1,
    MAP_TREE_GREEN_2,
    MAP_STONE_WALL_RUIN,
    MAP_STONE_FLOOR_RUIN,
    ICON_ATTACK_UP,
    ICON_ATTACK_DOWN,
    ICON_DEFENSE_UP,
    ICON_DEFENSE_DOWN,
    ICON_BLEEDING,
    ICON_FREEZING,
    EFFECT_BLOCK_OF_ICE_FOR_SPELL,
    ICON_HASNT_SEEN_YOU,
    ITEM_MAXIM_GUN,
    EFFECT_CRIT,
    EFFECT_CRIT_AT_AN_ANGLE,
    EFFECT_MUSICAL_NOTE,
    PARTICLE_SNOW_3X3,
    PARTICLE_SNOW_4X4,
    PARTICLE_SNOW_6X6,
    MAP_HENGE_STONE_1,
    MAP_HENGE_STONE_2,
    MAP_HENGE_STONE_3,
    MAP_HENGE_STONE_4,
    EFFECT_FULLSQUARE,
    COMBAT_GRID_ATTACK,
    COMBAT_GRID_DEFENCE,
    COMBAT_GRID_VULNERABLE,
    INVENTORY_HAND,
    ITEM_FISHING_ROD,
    ITEM_FISH

}
