using Padutronics.Interoperability;
using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;
using Padutronics.Windows.Win32.Api.Dxgi;
using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Factory : Unknown, ID2D1Factory
{
    public D2D1Factory(nint pointer) :
        base(pointer)
    {
    }

    public void CreateDxgiSurfaceRenderTarget(IDXGISurface dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1RenderTarget renderTarget)
    {
        D2D1FactoryMethods.ID2D1Factory_CreateDxgiSurfaceRenderTarget(This, dxgiSurface.Pointer, ref renderTargetProperties, out nint renderTargetPointer);

        renderTarget = new D2D1RenderTarget(renderTargetPointer);
    }

    public void CreateEllipseGeometry(D2D1_ELLIPSE ellipse, out ID2D1EllipseGeometry ellipseGeometry)
    {
        D2D1FactoryMethods.ID2D1Factory_CreateEllipseGeometry(This, ref ellipse, out nint ellipseGeometryPointer);

        ellipseGeometry = new D2D1EllipseGeometry(ellipseGeometryPointer);
    }

    public void CreateGeometryGroup(D2D1_FILL_MODE fillMode, ID2D1Geometry[] geometries, int geometriesCount, out ID2D1GeometryGroup geometryGroup)
    {
        D2D1FactoryMethods.ID2D1Factory_CreateGeometryGroup(This, fillMode, geometries.ToArrayOfPointers(), geometriesCount, out nint geometryGroupPointer);

        geometryGroup = new D2D1GeometryGroup(geometryGroupPointer);
    }

    public void CreatePathGeometry(out ID2D1PathGeometry pathGeometry)
    {
        D2D1FactoryMethods.ID2D1Factory_CreatePathGeometry(This, out nint pathGeometryPointer);

        pathGeometry = new D2D1PathGeometry(pathGeometryPointer);
    }

    public void CreateRectangleGeometry(D2D_RECT_F rectangle, out ID2D1RectangleGeometry rectangleGeometry)
    {
        D2D1FactoryMethods.ID2D1Factory_CreateRectangleGeometry(This, ref rectangle, out nint rectangleGeometryPointer);

        rectangleGeometry = new D2D1RectangleGeometry(rectangleGeometryPointer);
    }

    public void CreateStrokeStyle(D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, float[]? dashes, int dashesCount, out ID2D1StrokeStyle strokeStyle)
    {
        D2D1FactoryMethods.ID2D1Factory_CreateStrokeStyle(This, ref strokeStyleProperties, dashes, dashesCount, out nint strokeStylePointer);

        strokeStyle = new D2D1StrokeStyle(strokeStylePointer);
    }
}