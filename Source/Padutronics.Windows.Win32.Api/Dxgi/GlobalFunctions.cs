using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public static class GlobalFunctions
{
    [DllImport(DllNames.Dxgi, PreserveSig = false)]
    public static extern void CreateDXGIFactory(ref Guid riid, out IntPtr ppFactory);
}