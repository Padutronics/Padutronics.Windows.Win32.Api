using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1RectangleGeometryMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RectangleGeometry_GetRect(nint @this, out D2D_RECT_F rect);
}