using Padutronics.Windows.Win32.Api.WinDef;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.WinUser;

public static class GlobalFunctions
{
    [DllImport(DllNames.User32, SetLastError = true)]
    public static extern bool AdjustWindowRectEx(ref RECT lpRect, WS dwStyle, bool bMenu, WS_EX dwExStyle);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern nint CreateWindowExW(WS_EX dwExStyle, nint lpClassName, string lpWindowName, WS dwStyle, int X, int Y, int nWidth, int nHeight, nint hWndParent, nint hMenu, nint hInstance, nint lpParam);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern nint DefWindowProcW(nint hWnd, WM Msg, nint wParam, nint lParam);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern nint DispatchMessageW(ref MSG lpMsg);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern int GetMessageW(ref MSG lpMsg, nint hWnd, WM wMsgFilterMin, WM wMsgFilterMax);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool GetMonitorInfoW(nint hMonitor, ref MONITORINFO lpmi);

    [DllImport(DllNames.User32, SetLastError = true)]
    public static extern int GetSystemMetrics(SM nIndex);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern nint LoadCursorW(nint hInstance, nint lpCursorName);

    [DllImport(DllNames.User32, SetLastError = true)]
    public static extern nint MonitorFromWindow(nint hwnd, MONITOR dwFlags);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool PeekMessageW(ref MSG lpMsg, nint hWnd, WM wMsgFilterMin, WM wMsgFilterMax, PM wRemoveMsg);

    [DllImport(DllNames.User32, SetLastError = true)]
    public static extern void PostQuitMessage(int nExitCode);

    [DllImport(DllNames.User32, SetLastError = true)]
    public static extern bool ReleaseCapture();

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern ushort RegisterClassExW(ref WNDCLASSEXW lpwcx);

    [DllImport(DllNames.User32, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern nint SendMessageW(nint hWnd, WM Msg, nint wParam, nint lParam);

    [DllImport(DllNames.User32, SetLastError = true)]
    public static extern nint TranslateMessage(ref MSG lpMsg);
}