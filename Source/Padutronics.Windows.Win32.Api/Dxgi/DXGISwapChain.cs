using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGISwapChain : DXGIDeviceSubObject, IDXGISwapChain
{
    public DXGISwapChain(IntPtr pointer) :
        base(pointer)
    {
    }
}