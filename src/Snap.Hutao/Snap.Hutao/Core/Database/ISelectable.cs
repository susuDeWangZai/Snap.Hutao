﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

namespace Snap.Hutao.Core.Database;

/// <summary>
/// 可选择的项
/// 若要使用 <see cref="DbCurrent{TEntity, TMessage}"/>
/// 或 <see cref="ScopedDbCurrent{TEntity, TMessage}"/>
/// 必须实现该接口
/// </summary>
[HighQuality]
internal interface ISelectable
{
    /// <summary>
    /// 数据库内部Id
    /// </summary>
    Guid InnerId { get; }

    /// <summary>
    /// 获取或设置当前项的选中状态
    /// </summary>
    bool IsSelected { get; set; }
}