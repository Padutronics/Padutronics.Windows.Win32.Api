using Padutronics.Windows.Win32.Api.WinDef;

namespace Padutronics.Windows.Win32.Api.WinUser;

public struct MINMAXINFO
{
    public POINT ptReserved;
    public POINT ptMaxSize;
    public POINT ptMaxPosition;
    public POINT ptMinTrackSize;
    public POINT ptMaxTrackSize;
}