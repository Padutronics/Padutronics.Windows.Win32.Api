using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.WinUser;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate IntPtr WNDPROC(IntPtr hwnd, WM uMsg, IntPtr wParam, IntPtr lParam);