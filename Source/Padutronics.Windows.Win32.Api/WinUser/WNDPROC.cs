using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.WinUser;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nint WNDPROC(nint hwnd, WM uMsg, nint wParam, nint lParam);