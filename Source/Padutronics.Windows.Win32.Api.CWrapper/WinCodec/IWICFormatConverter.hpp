#pragma once

#include "..\Configuration.hpp"

#include <wincodec.h>

EXPORT auto IWICFormatConverter_Initialize(IWICFormatConverter& _this, IWICBitmapSource* pISource, REFWICPixelFormatGUID dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate) -> HRESULT;