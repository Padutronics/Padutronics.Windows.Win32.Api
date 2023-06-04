using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGIObject : Unknown, IDXGIObject
{
    public DXGIObject(nint pointer) :
        base(pointer)
    {
    }
}