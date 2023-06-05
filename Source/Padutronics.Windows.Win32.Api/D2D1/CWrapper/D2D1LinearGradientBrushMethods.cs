using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1LinearGradientBrushMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D_POINT_2F ID2D1LinearGradientBrush_GetEndPoint(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D_POINT_2F ID2D1LinearGradientBrush_GetStartPoint(nint @this);
}