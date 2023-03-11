using System;

namespace Padutronics.Windows.Win32.Api.WinUser;

public static class Macros
{
    public static short HIWORD(int value)
    {
        return (short)(value >> 16);
    }

    public static short HIWORD(IntPtr value)
    {
        return HIWORD(unchecked((int)value.ToInt64()));
    }
}