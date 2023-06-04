namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11RenderTargetView : D3D11View, ID3D11RenderTargetView
{
    public D3D11RenderTargetView(nint pointer) :
        base(pointer)
    {
    }
}