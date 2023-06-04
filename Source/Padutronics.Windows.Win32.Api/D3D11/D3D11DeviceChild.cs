using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11DeviceChild : Unknown, ID3D11DeviceChild
{
    public D3D11DeviceChild(nint pointer) :
        base(pointer)
    {
    }
}