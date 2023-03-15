using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11DeviceChild : Unknown, ID3D11DeviceChild
{
    public D3D11DeviceChild(IntPtr pointer) :
        base(pointer)
    {
    }
}