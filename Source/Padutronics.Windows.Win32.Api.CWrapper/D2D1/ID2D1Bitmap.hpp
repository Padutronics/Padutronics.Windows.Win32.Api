#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT void ID2D1Bitmap_GetDpi(ID2D1Bitmap& _this, FLOAT* dpiX, FLOAT* dpiY);
EXPORT auto ID2D1Bitmap_GetPixelFormat(ID2D1Bitmap& _this) -> D2D1_PIXEL_FORMAT;
EXPORT auto ID2D1Bitmap_GetPixelSize(ID2D1Bitmap& _this) -> D2D1_SIZE_U;
EXPORT auto ID2D1Bitmap_GetSize(ID2D1Bitmap& _this) -> D2D1_SIZE_F;