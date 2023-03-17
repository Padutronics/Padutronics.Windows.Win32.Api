#pragma once

#include "..\Configuration.hpp"

#include <wincodec.h>

EXPORT auto IWICImagingFactory_CreateDecoderFromStream(IWICImagingFactory& _this, IStream* pIStream, const GUID* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder) -> HRESULT;