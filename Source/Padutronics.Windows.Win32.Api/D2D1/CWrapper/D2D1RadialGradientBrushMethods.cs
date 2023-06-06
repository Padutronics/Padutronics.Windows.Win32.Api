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
    public static extern float ID2D1RadialGradientBrush_GetRadiusX(nint @this);
}