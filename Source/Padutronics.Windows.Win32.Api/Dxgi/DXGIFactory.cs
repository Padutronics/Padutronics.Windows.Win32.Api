using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGIFactory : DXGIObject, IDXGIFactory
{
    public DXGIFactory(IntPtr pointer) :
        base(pointer)
    {
    }
}