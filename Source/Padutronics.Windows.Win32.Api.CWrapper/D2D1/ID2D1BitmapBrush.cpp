#include "ID2D1BitmapBrush.hpp"

void ID2D1BitmapBrush_GetBitmap(ID2D1BitmapBrush& _this, ID2D1Bitmap** bitmap)
{
    _this.GetBitmap(bitmap);
}

auto ID2D1BitmapBrush_GetExtendModeX(ID2D1BitmapBrush& _this) -> D2D1_EXTEND_MODE
{
    return _this.GetExtendModeX();
}

auto ID2D1BitmapBrush_GetExtendModeY(ID2D1BitmapBrush& _this) -> D2D1_EXTEND_MODE
{
    return _this.GetExtendModeY();
}

auto ID2D1BitmapBrush_GetInterpolationMode(ID2D1BitmapBrush& _this) -> D2D1_BITMAP_INTERPOLATION_MODE
{
    return _this.GetInterpolationMode();
}

void ID2D1BitmapBrush_SetBitmap(ID2D1BitmapBrush& _this, ID2D1Bitmap* bitmap)
{
    _this.SetBitmap(bitmap);
}