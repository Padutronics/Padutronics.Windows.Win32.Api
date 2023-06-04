#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1Bitmap_GetPixelSize(ID2D1Bitmap& _this) -> D2D1_SIZE_U;
EXPORT auto ID2D1Bitmap_GetSize(ID2D1Bitmap& _this) -> D2D1_SIZE_F;