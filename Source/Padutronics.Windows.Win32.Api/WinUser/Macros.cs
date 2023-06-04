namespace Padutronics.Windows.Win32.Api.WinUser;

public static class Macros
{
    public static short HIWORD(int value)
    {
        return (short)(value >> 16);
    }

    public static short HIWORD(nint value)
    {
        return HIWORD(unchecked((int)value.ToInt64()));
    }

    public static short LOWORD(int value)
    {
        return (short)(value & 0x0000FFFF);
    }

    public static short LOWORD(nint value)
    {
        return LOWORD(unchecked((int)value.ToInt64()));
    }
}