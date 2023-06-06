#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT void ID2D1BitmapBrush_GetBitmap(ID2D1BitmapBrush& _this, ID2D1Bitmap** bitmap);
EXPORT auto ID2D1BitmapBrush_GetExtendModeX(ID2D1BitmapBrush& _this) -> D2D1_EXTEND_MODE;
EXPORT auto ID2D1BitmapBrush_GetExtendModeY(ID2D1BitmapBrush& _this) -> D2D1_EXTEND_MODE;
EXPORT auto ID2D1BitmapBrush_GetInterpolationMode(ID2D1BitmapBrush& _this) -> D2D1_BITMAP_INTERPOLATION_MODE;
EXPORT void ID2D1BitmapBrush_SetBitmap(ID2D1BitmapBrush& _this, ID2D1Bitmap* bitmap);
EXPORT void ID2D1BitmapBrush_SetExtendModeX(ID2D1BitmapBrush& _this, D2D1_EXTEND_MODE extendModeX);
EXPORT void ID2D1BitmapBrush_SetExtendModeY(ID2D1BitmapBrush& _this, D2D1_EXTEND_MODE extendModeY);
EXPORT void ID2D1BitmapBrush_SetInterpolationMode(ID2D1BitmapBrush& _this, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);