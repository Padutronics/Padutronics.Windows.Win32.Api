using Padutronics.Windows.Win32.Api.WinDef;

namespace Padutronics.Windows.Win32.Api.WinUser;

public struct MSG
{
    public nint hwnd;
    public WM message;
    public nint wParam;
    public nint lParam;
    public int time;
    public POINT pt;
}