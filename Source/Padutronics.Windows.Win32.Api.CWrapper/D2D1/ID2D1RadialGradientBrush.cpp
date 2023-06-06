#include "ID2D1RadialGradientBrush.hpp"

auto ID2D1RadialGradientBrush_GetCenter(ID2D1RadialGradientBrush& _this) -> D2D1_POINT_2F
{
    return _this.GetCenter();
}