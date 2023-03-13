using System;

namespace Padutronics.Windows.Win32.Api.WinUser;

[Flags]
public enum PM
{
    PM_NOREMOVE = 0x0000,
    PM_REMOVE = 0x0001,
    PM_NOYIELD = 0x0002
}