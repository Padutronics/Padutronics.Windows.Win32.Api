using Padutronics.Windows.Win32.Api.Dxgi.CWrapper;
using Padutronics.Windows.Win32.Api.DxgiFormat;
using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGISwapChain : DXGIDeviceSubObject, IDXGISwapChain
{
    public DXGISwapChain(nint pointer) :
        base(pointer)
    {
    }

    public void GetBuffer(int Buffer, Guid riid, out nint ppSurface)
    {
        DXGISwapChainMethods.IDXGISwapChain_GetBuffer(This, Buffer, ref riid, out ppSurface);
    }

    public void Present(int SyncInterval, DXGI_PRESENT Flags)
    {
        DXGISwapChainMethods.IDXGISwapChain_Present(This, SyncInterval, Flags);
    }

    public void ResizeBuffers(int BufferCount, int Width, int Height, DXGI_FORMAT NewFormat, DXGI_SWAP_CHAIN_FLAG SwapChainFlags)
    {
        DXGISwapChainMethods.IDXGISwapChain_ResizeBuffers(This, BufferCount, Width, Height, NewFormat, SwapChainFlags);
    }
}