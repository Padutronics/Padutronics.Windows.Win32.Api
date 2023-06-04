using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1FactoryMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Factory_CreateDxgiSurfaceRenderTarget(nint @this, nint dxgiSurface, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out nint renderTarget);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Factory_CreateEllipseGeometry(nint @this, ref D2D1_ELLIPSE ellipse, out nint ellipseGeometry);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Factory_CreateGeometryGroup(nint @this, D2D1_FILL_MODE fillMode, nint[] geometries, int geometriesCount, out nint geometryGroup);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Factory_CreatePathGeometry(nint @this, out nint pathGeometry);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Factory_CreateRectangleGeometry(nint @this, ref D2D_RECT_F rectangle, out nint rectangleGeometry);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Factory_CreateStrokeStyle(nint @this, ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, float[]? dashes, int dashesCount, out nint strokeStyle);
}