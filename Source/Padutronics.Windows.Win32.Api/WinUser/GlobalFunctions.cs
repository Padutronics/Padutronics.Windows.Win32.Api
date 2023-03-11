using Padutronics.Windows.Win32.Api.WinDef;
using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.WinUser;

public static class GlobalFunctions
{
    [DllImport(DllNames.User32, SetLastError = true)]
    public static extern bool AdjustWindowRectEx(ref RECT lpRect, WS dwStyle, bool bMenu, WS_EX dwExStyle);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr CreateWindowExW(WS_EX dwExStyle, IntPtr lpClassName, string lpWindowName, WS dwStyle, int X, int Y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr DefWindowProcW(IntPtr hWnd, WM Msg, IntPtr wParam, IntPtr lParam);

    [DllImport(DllNames.User32, SetLastError = true)]
    public static extern int GetSystemMetrics(SM nIndex);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr LoadCursorW(IntPtr hInstance, IntPtr lpCursorName);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern ushort RegisterClassExW(ref WNDCLASSEXW lpwcx);
}