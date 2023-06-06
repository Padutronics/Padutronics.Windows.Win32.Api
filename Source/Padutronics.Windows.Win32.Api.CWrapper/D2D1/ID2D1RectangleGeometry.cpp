#include "ID2D1RectangleGeometry.hpp"

void ID2D1RectangleGeometry_GetRect(ID2D1RectangleGeometry& _this, D2D1_RECT_F* rect)
{
    _this.GetRect(rect);
}