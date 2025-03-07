﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Hutao.Service.GachaLog;

namespace Snap.Hutao.ViewModel.GachaLog;

/// <summary>
/// 简化的祈愿记录视图模型
/// </summary>
[Injection(InjectAs.Scoped)]
internal sealed class GachaLogViewModelSlim : Abstraction.ViewModelSlim<View.Page.GachaLogPage>
{
    private List<GachaStatisticsSlim>? statisticsList;

    /// <summary>
    /// 构造一个新的简化的祈愿记录视图模型
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    public GachaLogViewModelSlim(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
    }

    /// <summary>
    /// 统计列表
    /// </summary>
    public List<GachaStatisticsSlim>? StatisticsList { get => statisticsList; set => SetProperty(ref statisticsList, value); }

    /// <inheritdoc/>
    protected override async Task OpenUIAsync()
    {
        IGachaLogService gachaLogService = ServiceProvider.GetRequiredService<IGachaLogService>();

        if (await gachaLogService.InitializeAsync(default).ConfigureAwait(false))
        {
            List<GachaStatisticsSlim> list = await gachaLogService.GetStatisticsSlimsAsync().ConfigureAwait(false);
            await ThreadHelper.SwitchToMainThreadAsync();
            StatisticsList = list;
            IsInitialized = true;
        }
    }
}