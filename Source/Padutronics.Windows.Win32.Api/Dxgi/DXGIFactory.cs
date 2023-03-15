using Padutronics.Windows.Win32.Api.Dxgi.CWrapper;
using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGIFactory : DXGIObject, IDXGIFactory
{
    public DXGIFactory(IntPtr pointer) :
        base(pointer)
    {
    }

    public void EnumAdapters(int Adapter, out IDXGIAdapter ppAdapter)
    {
        DXGIFactoryMethods.IDXGIFactory_EnumAdapters(This, Adapter, out IntPtr ppAdapterPointer);

        ppAdapter = new DXGIAdapter(ppAdapterPointer);
    }
}