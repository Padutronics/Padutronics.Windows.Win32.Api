using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Dxgi.CWrapper;

internal static class DXGIFactoryMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IDXGIFactory_EnumAdapters(IntPtr @this, int Adapter, out IntPtr ppAdapter);
}