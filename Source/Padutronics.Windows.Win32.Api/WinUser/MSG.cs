using Padutronics.Windows.Win32.Api.WinDef;
using System;

namespace Padutronics.Windows.Win32.Api.WinUser;

public struct MSG
{
    public IntPtr hwnd;
    public WM message;
    public IntPtr wParam;
    public IntPtr lParam;
    public int time;
    public POINT pt;
}