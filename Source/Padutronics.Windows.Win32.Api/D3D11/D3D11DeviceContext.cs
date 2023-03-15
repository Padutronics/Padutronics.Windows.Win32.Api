using System;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11DeviceContext : D3D11DeviceChild, ID3D11DeviceContext
{
    public D3D11DeviceContext(IntPtr pointer) :
        base(pointer)
    {
    }
}