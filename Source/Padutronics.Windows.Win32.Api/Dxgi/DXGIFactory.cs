using Padutronics.Windows.Win32.Api.Dxgi.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGIFactory : DXGIObject, IDXGIFactory
{
    public DXGIFactory(IntPtr pointer) :
        base(pointer)
    {
    }

    public void CreateSwapChain(IUnknown pDevice, DXGI_SWAP_CHAIN_DESC pDesc, out IDXGISwapChain ppSwapChain)
    {
        DXGIFactoryMethods.IDXGIFactory_CreateSwapChain(This, pDevice.Pointer, ref pDesc, out IntPtr ppSwapChainPointer);

        ppSwapChain = new DXGISwapChain(ppSwapChainPointer);
    }

    public void EnumAdapters(int Adapter, out IDXGIAdapter ppAdapter)
    {
        DXGIFactoryMethods.IDXGIFactory_EnumAdapters(This, Adapter, out IntPtr ppAdapterPointer);

        ppAdapter = new DXGIAdapter(ppAdapterPointer);
    }
}