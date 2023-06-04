using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1BitmapMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D_SIZE_U ID2D1Bitmap_GetPixelSize(nint @this);
}