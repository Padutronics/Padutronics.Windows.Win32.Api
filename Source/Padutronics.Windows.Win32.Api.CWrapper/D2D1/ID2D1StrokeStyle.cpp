#include "ID2D1StrokeStyle.hpp"

auto ID2D1StrokeStyle_GetDashCap(ID2D1StrokeStyle& _this) -> D2D1_CAP_STYLE
{
    return _this.GetDashCap();
}

auto ID2D1StrokeStyle_GetDashOffset(ID2D1StrokeStyle& _this) -> FLOAT
{
    return _this.GetDashOffset();
}

auto ID2D1StrokeStyle_GetDashStyle(ID2D1StrokeStyle& _this) -> D2D1_DASH_STYLE
{
    return _this.GetDashStyle();
}

auto ID2D1StrokeStyle_GetEndCap(ID2D1StrokeStyle& _this) -> D2D1_CAP_STYLE
{
    return _this.GetEndCap();
}

auto ID2D1StrokeStyle_GetStartCap(ID2D1StrokeStyle& _this) -> D2D1_CAP_STYLE
{
    return _this.GetStartCap();
}