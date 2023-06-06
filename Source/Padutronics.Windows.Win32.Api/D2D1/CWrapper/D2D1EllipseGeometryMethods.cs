using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1EllipseGeometryMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1EllipseGeometry_GetEllipse(nint @this, out D2D1_ELLIPSE ellipse);
}