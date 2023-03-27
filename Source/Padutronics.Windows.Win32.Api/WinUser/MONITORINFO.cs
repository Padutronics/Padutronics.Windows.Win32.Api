using Padutronics.Windows.Win32.Api.WinDef;

namespace Padutronics.Windows.Win32.Api.WinUser;

public struct MONITORINFO
{
    public int cbSize;
    public RECT rcMonitor;
    public RECT rcWork;
    public MONITORINFOF dwFlags;
}