using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Dxgi.CWrapper;

internal static class DXGISwapChainMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IDXGISwapChain_GetBuffer(IntPtr @this, int Buffer, ref Guid riid, out IntPtr ppSurface);
}