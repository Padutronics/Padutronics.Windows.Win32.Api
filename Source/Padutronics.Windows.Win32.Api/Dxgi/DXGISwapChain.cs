using Padutronics.Windows.Win32.Api.Dxgi.CWrapper;
using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGISwapChain : DXGIDeviceSubObject, IDXGISwapChain
{
    public DXGISwapChain(IntPtr pointer) :
        base(pointer)
    {
    }

    public void GetBuffer(int Buffer, Guid riid, out IntPtr ppSurface)
    {
        DXGISwapChainMethods.IDXGISwapChain_GetBuffer(This, Buffer, ref riid, out ppSurface);
    }

    public void Present(int SyncInterval, DXGI_PRESENT Flags)
    {
        DXGISwapChainMethods.IDXGISwapChain_Present(This, SyncInterval, Flags);
    }
}