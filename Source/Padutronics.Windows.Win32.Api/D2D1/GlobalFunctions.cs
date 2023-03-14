using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

public static class GlobalFunctions
{
    [DllImport(DllNames.D2D1, PreserveSig = false)]
    public static extern void D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, ref Guid riid, ref D2D1_FACTORY_OPTIONS pFactoryOptions, out IntPtr ppIFactory);
}