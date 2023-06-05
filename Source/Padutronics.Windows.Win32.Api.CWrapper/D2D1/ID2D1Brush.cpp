#include "ID2D1Brush.hpp"

auto ID2D1Brush_GetOpacity(ID2D1Brush& _this) -> FLOAT
{
    return _this.GetOpacity();
}