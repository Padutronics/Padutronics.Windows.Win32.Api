using Padutronics.Windows.Win32.Api.DxgiFormat;
using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Dxgi.CWrapper;

internal static class DXGISwapChainMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IDXGISwapChain_GetBuffer(nint @this, int Buffer, ref Guid riid, out nint ppSurface);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IDXGISwapChain_Present(nint @this, int SyncInterval, DXGI_PRESENT Flags);

    [DllImport(DllNames.CWrapper, PreserveSig = true)]
    public static extern void IDXGISwapChain_ResizeBuffers(nint @this, int BufferCount, int Width, int Height, DXGI_FORMAT NewFormat, DXGI_SWAP_CHAIN_FLAG SwapChainFlags);
}