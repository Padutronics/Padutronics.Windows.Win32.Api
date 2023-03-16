using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DxgiType;
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

    public void CreateSolidColorBrush(D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        D2D1_BRUSH_PROPERTIES brushPropertiesCopy;

        IntPtr brushPropertiesPointer = IntPtr.Zero;

        if (brushProperties.HasValue)
        {
            brushPropertiesCopy = brushProperties.Value;

            unsafe
            {
                brushPropertiesPointer = new IntPtr(&brushPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateSolidColorBrush(This, ref color, brushPropertiesPointer, out IntPtr solidColorBrushPointer);

        solidColorBrush = new D2D1SolidColorBrush(solidColorBrushPointer);
    }

    public void EndDraw(out long tag1, out long tag2)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_EndDraw(This, out tag1, out tag2);
    }
}