#include "ID2D1LinearGradientBrush.hpp"

auto ID2D1LinearGradientBrush_GetEndPoint(ID2D1LinearGradientBrush& _this) -> D2D1_POINT_2F
{
    return _this.GetEndPoint();
}