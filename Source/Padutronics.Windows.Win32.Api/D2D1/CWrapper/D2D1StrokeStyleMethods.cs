using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1StrokeStyleMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_CAP_STYLE ID2D1StrokeStyle_GetDashCap(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern float ID2D1StrokeStyle_GetDashOffset(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_DASH_STYLE ID2D1StrokeStyle_GetDashStyle(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_CAP_STYLE ID2D1StrokeStyle_GetEndCap(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_CAP_STYLE ID2D1StrokeStyle_GetStartCap(nint @this);
}