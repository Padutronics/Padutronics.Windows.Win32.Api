using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGIDeviceSubObject : DXGIObject, IDXGIDeviceSubObject
{
    public DXGIDeviceSubObject(IntPtr pointer) :
        base(pointer)
    {
    }
}