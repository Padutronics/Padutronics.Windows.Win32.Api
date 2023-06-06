using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1GradientStopCollectionMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_GAMMA ID2D1GradientStopCollection_GetColorInterpolationGamma(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_EXTEND_MODE ID2D1GradientStopCollection_GetExtendMode(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern int ID2D1GradientStopCollection_GetGradientStopCount(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1GradientStopCollection_GetGradientStops(nint @this, D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount);
}