﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Hutao.Model.Entity;
using Snap.Hutao.Model.Entity.Database;
using Snap.Hutao.Model.InterChange.GachaLog;
using Snap.Hutao.Model.Metadata.Abstraction;

namespace Snap.Hutao.Service.GachaLog;

/// <summary>
/// 祈愿记录导出服务
/// </summary>
[Injection(InjectAs.Scoped, typeof(IGachaLogExportService))]
internal sealed class GachaLogExportService : IGachaLogExportService
{
    private readonly AppDbContext appDbContext;

    /// <summary>
    /// 构造一个新的祈愿记录导出服务
    /// </summary>
    /// <param name="appDbContext">数据库上下文</param>
    public GachaLogExportService(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    /// <inheritdoc/>
    public async Task<UIGF> ExportToUIGFAsync(GachaLogServiceContext context, GachaArchive archive)
    {
        await ThreadHelper.SwitchToBackgroundAsync();
        List<UIGFItem> list = appDbContext.GachaItems
            .Where(i => i.ArchiveId == archive.InnerId)
            .AsEnumerable()
            .Select(i => i.ToUIGFItem(context.GetNameQualityByItemId(i.ItemId)))
            .ToList();

        UIGF uigf = new()
        {
            Info = UIGFInfo.Create(archive.Uid),
            List = list,
        };

        return uigf;
    }
}