using Padutronics.Windows.Win32.Api.D3D11.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11Device : Unknown, ID3D11Device
{
    public D3D11Device(IntPtr pointer) :
        base(pointer)
    {
    }

    public void GetImmediateContext(out ID3D11DeviceContext ppImmediateContext)
    {
        D3D11DeviceMethods.ID3D11Device_GetImmediateContext(This, out IntPtr ppImmediateContextPointer);

        ppImmediateContext = new D3D11DeviceContext(ppImmediateContextPointer);
    }
}