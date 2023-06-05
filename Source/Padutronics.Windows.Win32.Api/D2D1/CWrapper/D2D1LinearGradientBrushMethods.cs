using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1LinearGradientBrushMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D_POINT_2F ID2D1LinearGradientBrush_GetEndPoint(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1LinearGradientBrush_GetGradientStopCollection(nint @this, out nint gradientStopCollection);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D_POINT_2F ID2D1LinearGradientBrush_GetStartPoint(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1LinearGradientBrush_SetEndPoint(nint @this, D2D_POINT_2F endPoint);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1LinearGradientBrush_SetStartPoint(nint @this, D2D_POINT_2F startPoint);
}