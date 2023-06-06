#include "ID2D1StrokeStyle.hpp"

auto ID2D1StrokeStyle_GetDashCap(ID2D1StrokeStyle& _this) -> D2D1_CAP_STYLE
{
    return _this.GetDashCap();
}