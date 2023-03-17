#include "IWICFormatConverter.hpp"

auto IWICFormatConverter_Initialize(IWICFormatConverter& _this, IWICBitmapSource* pISource, REFWICPixelFormatGUID dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate) -> HRESULT
{
    return _this.Initialize(pISource, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
}