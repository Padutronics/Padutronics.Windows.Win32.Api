#include "ID2D1Bitmap.hpp"

void ID2D1Bitmap_GetDpi(ID2D1Bitmap& _this, FLOAT* dpiX, FLOAT* dpiY)
{
    _this.GetDpi(dpiX, dpiY);
}

auto ID2D1Bitmap_GetPixelFormat(ID2D1Bitmap& _this) -> D2D1_PIXEL_FORMAT
{
    return _this.GetPixelFormat();
}

auto ID2D1Bitmap_GetPixelSize(ID2D1Bitmap& _this) -> D2D1_SIZE_U
{
    return _this.GetPixelSize();
}

auto ID2D1Bitmap_GetSize(ID2D1Bitmap& _this) -> D2D1_SIZE_F
{
    return _this.GetSize();
}