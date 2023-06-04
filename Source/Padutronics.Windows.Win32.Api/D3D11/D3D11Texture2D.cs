namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11Texture2D : D3D11Resource, ID3D11Texture2D
{
    public D3D11Texture2D(nint pointer) :
        base(pointer)
    {
    }
}