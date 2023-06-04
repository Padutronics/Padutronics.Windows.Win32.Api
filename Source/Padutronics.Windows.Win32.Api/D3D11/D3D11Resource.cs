namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11Resource : D3D11DeviceChild, ID3D11Resource
{
    public D3D11Resource(nint pointer) :
        base(pointer)
    {
    }
}