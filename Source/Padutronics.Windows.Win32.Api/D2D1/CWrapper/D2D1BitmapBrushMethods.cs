using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1BitmapBrushMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1BitmapBrush_GetBitmap(nint @this, out nint bitmap);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_EXTEND_MODE ID2D1BitmapBrush_GetExtendModeX(nint @this);
}