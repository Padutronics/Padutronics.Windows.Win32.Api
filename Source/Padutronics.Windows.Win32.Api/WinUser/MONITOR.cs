using System;

namespace Padutronics.Windows.Win32.Api.WinUser;

[Flags]
public enum MONITOR
{
    MONITOR_DEFAULTTONULL = 0x00000000,
    MONITOR_DEFAULTTOPRIMARY = 0x00000001,
    MONITOR_DEFAULTTONEAREST = 0x00000002
}