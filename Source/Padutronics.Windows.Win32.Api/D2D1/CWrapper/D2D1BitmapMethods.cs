using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1BitmapMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1Bitmap_GetDpi(nint @this, out float dpiX, out float dpiY);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_PIXEL_FORMAT ID2D1Bitmap_GetPixelFormat(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D_SIZE_U ID2D1Bitmap_GetPixelSize(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D_SIZE_F ID2D1Bitmap_GetSize(nint @this);
}