using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.WinCodec;

[Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94")]
public interface IWICFormatConverter : IWICBitmapSource
{
    void Initialize(IWICBitmapSource pISource, Guid dstFormat, WICBitmapDitherType dither, IWICPalette? pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);
}