﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Microsoft.UI.Xaml;
using Windows.Win32.Foundation;
using Windows.Win32.UI.Shell;
using Windows.Win32.UI.WindowsAndMessaging;
using static Windows.Win32.PInvoke;

namespace Snap.Hutao.Core.Windowing;

/// <summary>
/// 窗体子类管理器
/// </summary>
/// <typeparam name="TWindow">窗体类型</typeparam>
[HighQuality]
internal sealed class WindowSubclass<TWindow> : IDisposable
    where TWindow : Window, IExtendedWindowSource
{
    private const int WindowSubclassId = 101;
    private const int DragBarSubclassId = 102;

    private readonly WindowOptions<TWindow> options;

    // We have to explicitly hold a reference to SUBCLASSPROC
    private SUBCLASSPROC? windowProc;
    private SUBCLASSPROC? dragBarProc;

    /// <summary>
    /// 构造一个新的窗体子类管理器
    /// </summary>
    /// <param name="options">选项</param>
    public WindowSubclass(WindowOptions<TWindow> options)
    {
        this.options = options;
    }

    /// <summary>
    /// 尝试设置窗体子类
    /// </summary>
    /// <returns>是否设置成功</returns>
    public bool Initialize()
    {
        windowProc = new(OnSubclassProcedure);
        bool windowHooked = SetWindowSubclass(options.Hwnd, windowProc, WindowSubclassId, 0);

        bool titleBarHooked = true;

        // only hook up drag bar proc when use legacy Window.ExtendsContentIntoTitleBar
        if (options.UseLegacyDragBarImplementation)
        {
            titleBarHooked = false;
            HWND hwndDragBar = FindWindowEx(options.Hwnd, default, "DRAG_BAR_WINDOW_CLASS", default);

            if (!hwndDragBar.IsNull)
            {
                dragBarProc = new(OnDragBarProcedure);
                titleBarHooked = SetWindowSubclass(hwndDragBar, dragBarProc, DragBarSubclassId, 0);
            }
        }

        return windowHooked && titleBarHooked;
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        RemoveWindowSubclass(options.Hwnd, windowProc, WindowSubclassId);
        windowProc = null;

        if (options.UseLegacyDragBarImplementation)
        {
            RemoveWindowSubclass(options.Hwnd, dragBarProc, DragBarSubclassId);
            dragBarProc = null;
        }
    }

    private unsafe LRESULT OnSubclassProcedure(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam, nuint uIdSubclass, nuint dwRefData)
    {
        switch (uMsg)
        {
            case WM_GETMINMAXINFO:
                {
                    double scalingFactor = Persistence.GetScaleForWindowHandle(hwnd);
                    options.Window.ProcessMinMaxInfo((MINMAXINFO*)lParam.Value, scalingFactor);
                    break;
                }

            case WM_NCRBUTTONDOWN:
            case WM_NCRBUTTONUP:
                {
                    return (LRESULT)0; // WM_NULL
                }
        }

        return DefSubclassProc(hwnd, uMsg, wParam, lParam);
    }

    private LRESULT OnDragBarProcedure(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam, nuint uIdSubclass, nuint dwRefData)
    {
        switch (uMsg)
        {
            case WM_NCRBUTTONDOWN:
            case WM_NCRBUTTONUP:
                {
                    return (LRESULT)0; // WM_NULL
                }
        }

        return DefSubclassProc(hwnd, uMsg, wParam, lParam);
    }
}