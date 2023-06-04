namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGISurface : DXGIDeviceSubObject, IDXGISurface
{
    public DXGISurface(nint pointer) :
        base(pointer)
    {
    }
}