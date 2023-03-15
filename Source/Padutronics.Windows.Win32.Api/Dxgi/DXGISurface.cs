using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGISurface : DXGIDeviceSubObject, IDXGISurface
{
    public DXGISurface(IntPtr pointer) :
        base(pointer)
    {
    }
}