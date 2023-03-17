using Padutronics.Windows.Win32.Api.WinCodec.CWrapper;
using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICFormatConverter : WICBitmapSource, IWICFormatConverter
{
    public WICFormatConverter(IntPtr pointer) :
        base(pointer)
    {
    }

    public void Initialize(IWICBitmapSource pISource, Guid dstFormat, WICBitmapDitherType dither, IWICPalette? pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
    {
        WICFormatConverterMethods.IWICFormatConverter_Initialize(This, pISource.Pointer, ref dstFormat, dither, pIPalette?.Pointer ?? IntPtr.Zero, alphaThresholdPercent, paletteTranslate);
    }
}