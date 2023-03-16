#include "ID2D1Bitmap.hpp"

auto ID2D1Bitmap_GetPixelSize(ID2D1Bitmap& _this) -> D2D1_SIZE_U
{
    return _this.GetPixelSize();
}