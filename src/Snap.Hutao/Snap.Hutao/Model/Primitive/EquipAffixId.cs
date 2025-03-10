﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Hutao.Model.Primitive.Converter;

namespace Snap.Hutao.Model.Primitive;

/// <summary>
/// 6位 装备属性Id
/// </summary>
[HighQuality]
[JsonConverter(typeof(IdentityConverter<EquipAffixId>))]
internal readonly struct EquipAffixId : IEquatable<EquipAffixId>
{
    /// <summary>
    /// 值
    /// </summary>
    public readonly int Value;

    /// <summary>
    /// Initializes a new instance of the <see cref="EquipAffixId"/> struct.
    /// </summary>
    /// <param name="value">value</param>
    public EquipAffixId(int value)
    {
        Value = value;
    }

    public static implicit operator int(EquipAffixId value)
    {
        return value.Value;
    }

    public static implicit operator EquipAffixId(int value)
    {
        return new(value);
    }

    public static bool operator ==(EquipAffixId left, EquipAffixId right)
    {
        return left.Value == right.Value;
    }

    public static bool operator !=(EquipAffixId left, EquipAffixId right)
    {
        return !(left == right);
    }

    /// <inheritdoc/>
    public bool Equals(EquipAffixId other)
    {
        return Value == other.Value;
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is EquipAffixId other && Equals(other);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}