#pragma once

#include "../Configuration.hpp"

#include <wincodec.h>

EXPORT auto IWICBitmapDecoder_GetFrame(IWICBitmapDecoder& _this, UINT index, IWICBitmapFrameDecode** ppIBitmapFrame) -> HRESULT;