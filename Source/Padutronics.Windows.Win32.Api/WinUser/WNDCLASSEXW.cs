using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.WinUser;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct WNDCLASSEXW
{
    public int cbSize;
    public CS style;
    public WNDPROC lpfnWndProc;
    public int cbClsExtra;
    public int cbWndExtra;
    public nint hInstance;
    public nint hIcon;
    public nint hCursor;
    public nint hbrBackground;
    public string lpszMenuName;
    public string lpszClassName;
    public nint hIconSm;
}