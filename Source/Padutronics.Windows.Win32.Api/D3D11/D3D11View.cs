namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11View : D3D11DeviceChild, ID3D11View
{
    public D3D11View(nint pointer) :
        base(pointer)
    {
    }
}