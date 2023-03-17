using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.Dxgi;
using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Factory : Unknown, ID2D1Factory
{
    public D2D1Factory(IntPtr pointer) :
        base(pointer)
    {
    }

    public void CreateDxgiSurfaceRenderTarget(IDXGISurface dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1RenderTarget renderTarget)
    {
        D2D1FactoryMethods.ID2D1Factory_CreateDxgiSurfaceRenderTarget(This, dxgiSurface.Pointer, ref renderTargetProperties, out IntPtr renderTargetPointer);

        renderTarget = new D2D1RenderTarget(renderTargetPointer);
    }

    public void CreatePathGeometry(out ID2D1PathGeometry pathGeometry)
    {
        D2D1FactoryMethods.ID2D1Factory_CreatePathGeometry(This, out IntPtr pathGeometryPointer);

        pathGeometry = new D2D1PathGeometry(pathGeometryPointer);
    }

    public void CreateStrokeStyle(D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, float[]? dashes, int dashesCount, out ID2D1StrokeStyle strokeStyle)
    {
        D2D1FactoryMethods.ID2D1Factory_CreateStrokeStyle(This, ref strokeStyleProperties, dashes, dashesCount, out IntPtr strokeStylePointer);

        strokeStyle = new D2D1StrokeStyle(strokeStylePointer);
    }
}