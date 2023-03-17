using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.WinCodec.CWrapper;

internal static class WICFormatConverterMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IWICFormatConverter_Initialize(IntPtr @this, IntPtr pISource, ref Guid dstFormat, WICBitmapDitherType dither, IntPtr pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);
}