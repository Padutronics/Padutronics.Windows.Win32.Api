namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGIAdapter : DXGIObject, IDXGIAdapter
{
    public DXGIAdapter(nint pointer) :
        base(pointer)
    {
    }
}