using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1StrokeStyleMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_CAP_STYLE ID2D1StrokeStyle_GetDashCap(nint @this);
}