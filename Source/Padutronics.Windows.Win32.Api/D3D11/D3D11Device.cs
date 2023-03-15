using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11Device : Unknown, ID3D11Device
{
    public D3D11Device(IntPtr pointer) :
        base(pointer)
    {
    }
}