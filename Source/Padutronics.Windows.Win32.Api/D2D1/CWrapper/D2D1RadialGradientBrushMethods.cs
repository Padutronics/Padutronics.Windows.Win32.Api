using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1RadialGradientBrushMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D_POINT_2F ID2D1RadialGradientBrush_GetCenter(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D_POINT_2F ID2D1RadialGradientBrush_GetGradientOriginOffset(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RadialGradientBrush_GetGradientStopCollection(nint @this, out nint gradientStopCollection);

    [DllImport(DllNames.CWrapper)]
    public static extern float ID2D1RadialGradientBrush_GetRadiusX(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern float ID2D1RadialGradientBrush_GetRadiusY(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RadialGradientBrush_SetCenter(nint @this, D2D_POINT_2F center);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RadialGradientBrush_SetGradientOriginOffset(nint @this, D2D_POINT_2F gradientOriginOffset);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RadialGradientBrush_SetRadiusX(nint @this, float radiusX);
}