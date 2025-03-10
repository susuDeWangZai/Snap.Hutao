﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Hutao.Model.Metadata.Annotation;

namespace Snap.Hutao.Model.Intrinsic;

/// <summary>
/// 战斗属性
/// </summary>
[HighQuality]
internal enum FightProperty
{
    /// <summary>
    /// 空
    /// </summary>
    FIGHT_PROP_NONE = 0,

    /// <summary>
    /// 基础生命值
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyBaseHp")]
    [Format(FormatMethod.Integer)]
    FIGHT_PROP_BASE_HP = 1,

    /// <summary>
    /// 小生命值加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyHp")]
    [Format(FormatMethod.Integer)]
    FIGHT_PROP_HP = 2,

    /// <summary>
    /// 生命值加成百分比
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyHp")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_HP_PERCENT = 3,

    /// <summary>
    /// 基础攻击力
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyBaseAtk")]
    [Format(FormatMethod.Integer)]
    FIGHT_PROP_BASE_ATTACK = 4,

    /// <summary>
    /// 攻击力加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyAtk")]
    [Format(FormatMethod.Integer)]
    FIGHT_PROP_ATTACK = 5,

    /// <summary>
    /// 攻击力百分比
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyAtk")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_ATTACK_PERCENT = 6,

    /// <summary>
    /// 基础防御力
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyBaseDef")]
    [Format(FormatMethod.Integer)]
    FIGHT_PROP_BASE_DEFENSE = 7,

    /// <summary>
    /// 防御力加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDef")]
    [Format(FormatMethod.Integer)]
    FIGHT_PROP_DEFENSE = 8,

    /// <summary>
    /// 防御力百分比
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDef")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_DEFENSE_PERCENT = 9,

    /// <summary>
    /// 基础速度
    /// </summary>
    FIGHT_PROP_BASE_SPEED = 10,

    /// <summary>
    /// 速度加成
    /// </summary>
    FIGHT_PROP_SPEED_PERCENT = 11,

    /// <summary>
    /// ？
    /// </summary>
    FIGHT_PROP_HP_MP_PERCENT = 12,

    /// <summary>
    /// ？
    /// </summary>
    FIGHT_PROP_ATTACK_MP_PERCENT = 13,

    /// <summary>
    /// 暴击率
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyCR")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_CRITICAL = 20,

    /// <summary>
    /// 抗暴击率
    /// </summary>
    FIGHT_PROP_ANTI_CRITICAL = 21,

    /// <summary>
    /// 暴击伤害
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyCDmg")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_CRITICAL_HURT = 22,

    /// <summary>
    /// 元素充能效率
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyCE")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_CHARGE_EFFICIENCY = 23,

    /// <summary>
    /// 伤害加成
    /// </summary>
    FIGHT_PROP_ADD_HURT = 24,

    /// <summary>
    /// 抗性提升
    /// </summary>
    FIGHT_PROP_SUB_HURT = 25,

    /// <summary>
    /// 治疗提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyHB")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_HEAL_ADD = 26,

    /// <summary>
    /// 受治疗提升
    /// </summary>
    FIGHT_PROP_HEALED_ADD = 27,

    /// <summary>
    /// 元素精通
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyEM")]
    [Format(FormatMethod.Integer)]
    FIGHT_PROP_ELEMENT_MASTERY = 28,

    /// <summary>
    /// 物理抗性提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyRESPhysical")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_PHYSICAL_SUB_HURT = 29,

    /// <summary>
    /// 物理伤害加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDBPhyiscal")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_PHYSICAL_ADD_HURT = 30,

    /// <summary>
    /// 无视防御力百分比
    /// </summary>
    FIGHT_PROP_DEFENCE_IGNORE_RATIO = 31,

    /// <summary>
    /// 防御力降低
    /// </summary>
    FIGHT_PROP_DEFENCE_IGNORE_DELTA = 32,

    /// <summary>
    /// 火元素伤害加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDBFire")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_FIRE_ADD_HURT = 40,

    /// <summary>
    /// 雷元素伤害加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDBElec")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_ELEC_ADD_HURT = 41,

    /// <summary>
    /// 水元素伤害加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDBWater")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_WATER_ADD_HURT = 42,

    /// <summary>
    /// 草元素伤害加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDBGrass")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_GRASS_ADD_HURT = 43,

    /// <summary>
    /// 风元素伤害加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDBWind")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_WIND_ADD_HURT = 44,

    /// <summary>
    /// 岩元素伤害加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDBRock")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_ROCK_ADD_HURT = 45,

    /// <summary>
    /// 冰元素伤害加成
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyDBIce")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_ICE_ADD_HURT = 46,

    /// <summary>
    /// 弱点伤害加成
    /// </summary>
    FIGHT_PROP_HIT_HEAD_ADD_HURT = 47,

    /// <summary>
    /// 火元素抗性提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyRESFire")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_FIRE_SUB_HURT = 50,

    /// <summary>
    /// 雷元素抗性提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyRESElec")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_ELEC_SUB_HURT = 51,

    /// <summary>
    /// 雷元素抗性提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyRESWater")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_WATER_SUB_HURT = 52,

    /// <summary>
    /// 草元素抗性提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyRESGrass")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_GRASS_SUB_HURT = 53,

    /// <summary>
    /// 风元素抗性提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyRESWind")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_WIND_SUB_HURT = 54,

    /// <summary>
    /// 岩元素抗性提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyRESRock")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_ROCK_SUB_HURT = 55,

    /// <summary>
    /// 冰元素抗性提升
    /// </summary>
    [LocalizationKey("ServiceAvatarInfoPropertyRESIce")]
    [Format(FormatMethod.Percent)]
    FIGHT_PROP_ICE_SUB_HURT = 56,

    /// <summary>
    /// ？
    /// </summary>
    FIGHT_PROP_EFFECT_HIT = 60,

    /// <summary>
    /// ？
    /// </summary>
    FIGHT_PROP_EFFECT_RESIST = 61,

    /// <summary>
    /// 冻结抗性
    /// </summary>
    FIGHT_PROP_FREEZE_RESIST = 62,

    /// <summary>
    /// 迟缓抗性
    /// </summary>
    FIGHT_PROP_TORPOR_RESIST = 63,

    /// <summary>
    /// 眩晕抗性
    /// </summary>
    FIGHT_PROP_DIZZY_RESIST = 64,

    /// <summary>
    /// 冻结缩减
    /// </summary>
    FIGHT_PROP_FREEZE_SHORTEN = 65,

    /// <summary>
    /// 迟缓缩减
    /// </summary>
    FIGHT_PROP_TORPOR_SHORTEN = 66,

    /// <summary>
    /// 眩晕缩减
    /// </summary>
    FIGHT_PROP_DIZZY_SHORTEN = 67,

    /// <summary>
    /// 火元素爆发能量
    /// </summary>
    FIGHT_PROP_MAX_FIRE_ENERGY = 70,

    /// <summary>
    /// 雷元素爆发能量
    /// </summary>
    FIGHT_PROP_MAX_ELEC_ENERGY = 71,

    /// <summary>
    /// 水元素爆发能量
    /// </summary>
    FIGHT_PROP_MAX_WATER_ENERGY = 72,

    /// <summary>
    /// 草元素爆发能量
    /// </summary>
    FIGHT_PROP_MAX_GRASS_ENERGY = 73,

    /// <summary>
    /// 风元素爆发能量
    /// </summary>
    FIGHT_PROP_MAX_WIND_ENERGY = 74,

    /// <summary>
    /// 冰元素爆发能量
    /// </summary>
    FIGHT_PROP_MAX_ICE_ENERGY = 75,

    /// <summary>
    /// 岩元素爆发能量
    /// </summary>
    FIGHT_PROP_MAX_ROCK_ENERGY = 76,

    /// <summary>
    /// 技能冷却缩减
    /// </summary>
    FIGHT_PROP_SKILL_CD_MINUS_RATIO = 80,

    /// <summary>
    /// 护盾强效
    /// </summary>
    FIGHT_PROP_SHIELD_COST_MINUS_RATIO = 81,

    /// <summary>
    /// 火元素爆发当前能量
    /// </summary>
    FIGHT_PROP_CUR_FIRE_ENERGY = 1000,

    /// <summary>
    /// 雷元素爆发当前能量
    /// </summary>
    FIGHT_PROP_CUR_ELEC_ENERGY = 1001,

    /// <summary>
    /// 水元素爆发当前能量
    /// </summary>
    FIGHT_PROP_CUR_WATER_ENERGY = 1002,

    /// <summary>
    /// 草元素爆发当前能量
    /// </summary>
    FIGHT_PROP_CUR_GRASS_ENERGY = 1003,

    /// <summary>
    /// 风元素爆发当前能量
    /// </summary>
    FIGHT_PROP_CUR_WIND_ENERGY = 1004,

    /// <summary>
    /// 冰元素爆发当前能量
    /// </summary>
    FIGHT_PROP_CUR_ICE_ENERGY = 1005,

    /// <summary>
    /// 岩元素爆发当前能量
    /// </summary>
    FIGHT_PROP_CUR_ROCK_ENERGY = 1006,

    /// <summary>
    /// 当前生命值
    /// </summary>
    FIGHT_PROP_CUR_HP = 1010,

    /// <summary>
    /// 最大生命值
    /// </summary>
    [Description("生命值")]
    [LocalizationKey("ServiceAvatarInfoPropertyHp")]
    [Format(FormatMethod.Integer)]
    FIGHT_PROP_MAX_HP = 2000,

    /// <summary>
    /// 当前攻击力
    /// </summary>
    FIGHT_PROP_CUR_ATTACK = 2001,

    /// <summary>
    /// 当前防御力
    /// </summary>
    FIGHT_PROP_CUR_DEFENSE = 2002,

    /// <summary>
    /// 当前速度
    /// </summary>
    FIGHT_PROP_CUR_SPEED = 2003,

    /// <summary>
    /// 总攻击力
    /// </summary>
    FIGHT_PROP_NONEXTRA_ATTACK = 3000,

    /// <summary>
    /// 总防御力
    /// </summary>
    FIGHT_PROP_NONEXTRA_DEFENSE = 3001,

    /// <summary>
    /// 总暴击率
    /// </summary>
    FIGHT_PROP_NONEXTRA_CRITICAL = 3002,

    /// <summary>
    /// 总抗暴击率
    /// </summary>
    FIGHT_PROP_NONEXTRA_ANTI_CRITICAL = 3003,

    /// <summary>
    /// 总暴击伤害
    /// </summary>
    FIGHT_PROP_NONEXTRA_CRITICAL_HURT = 3004,

    /// <summary>
    /// 总元素充能效率
    /// </summary>
    FIGHT_PROP_NONEXTRA_CHARGE_EFFICIENCY = 3005,

    /// <summary>
    /// 元素精通
    /// </summary>
    FIGHT_PROP_NONEXTRA_ELEMENT_MASTERY = 3006,

    /// <summary>
    /// 总物理抗性提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_PHYSICAL_SUB_HURT = 3007,

    /// <summary>
    /// 总火元素伤害提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_FIRE_ADD_HURT = 3008,

    /// <summary>
    /// 总雷元素伤害加成
    /// </summary>
    FIGHT_PROP_NONEXTRA_ELEC_ADD_HURT = 3009,

    /// <summary>
    /// 总水元素伤害加成
    /// </summary>
    FIGHT_PROP_NONEXTRA_WATER_ADD_HURT = 3010,

    /// <summary>
    /// 总草元素伤害加成
    /// </summary>
    FIGHT_PROP_NONEXTRA_GRASS_ADD_HURT = 3011,

    /// <summary>
    /// 总风元素伤害加成
    /// </summary>
    FIGHT_PROP_NONEXTRA_WIND_ADD_HURT = 3012,

    /// <summary>
    /// 总岩元素伤害加成
    /// </summary>
    FIGHT_PROP_NONEXTRA_ROCK_ADD_HURT = 3013,

    /// <summary>
    /// 总冰元素伤害加成
    /// </summary>
    FIGHT_PROP_NONEXTRA_ICE_ADD_HURT = 3014,

    /// <summary>
    /// 总火元素抗性提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_FIRE_SUB_HURT = 3015,

    /// <summary>
    /// 总雷元素抗性提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_ELEC_SUB_HURT = 3016,

    /// <summary>
    /// 总水元素抗性提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_WATER_SUB_HURT = 3017,

    /// <summary>
    /// 总草元素抗性提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_GRASS_SUB_HURT = 3018,

    /// <summary>
    /// 总风元素抗性提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_WIND_SUB_HURT = 3019,

    /// <summary>
    /// 总岩元素抗性提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_ROCK_SUB_HURT = 3020,

    /// <summary>
    /// 总冰元素抗性提升
    /// </summary>
    FIGHT_PROP_NONEXTRA_ICE_SUB_HURT = 3021,

    /// <summary>
    /// 总冷却缩减
    /// </summary>
    FIGHT_PROP_NONEXTRA_SKILL_CD_MINUS_RATIO = 3022,

    /// <summary>
    /// 总护盾强效
    /// </summary>
    FIGHT_PROP_NONEXTRA_SHIELD_COST_MINUS_RATIO = 3023,

    /// <summary>
    /// 总物理伤害加成
    /// </summary>
    FIGHT_PROP_NONEXTRA_PHYSICAL_ADD_HURT = 3024,
}