using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1RenderTarget : D2D1Resource, ID2D1RenderTarget
{
    public D2D1RenderTarget(IntPtr pointer) :
        base(pointer)
    {
    }

    public void BeginDraw()
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_BeginDraw(This);
    }
}