using System;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11DepthStencilView : D3D11View, ID3D11DepthStencilView
{
    public D3D11DepthStencilView(IntPtr pointer) :
        base(pointer)
    {
    }
}