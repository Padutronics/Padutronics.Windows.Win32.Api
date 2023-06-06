#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT void ID2D1BitmapBrush_GetBitmap(ID2D1BitmapBrush& _this, ID2D1Bitmap** bitmap);
EXPORT auto ID2D1BitmapBrush_GetExtendModeX(ID2D1BitmapBrush& _this) -> D2D1_EXTEND_MODE;