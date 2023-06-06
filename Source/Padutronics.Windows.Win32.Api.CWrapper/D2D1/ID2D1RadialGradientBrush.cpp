#include "ID2D1RadialGradientBrush.hpp"

auto ID2D1RadialGradientBrush_GetCenter(ID2D1RadialGradientBrush& _this) -> D2D1_POINT_2F
{
    return _this.GetCenter();
}

auto ID2D1RadialGradientBrush_GetGradientOriginOffset(ID2D1RadialGradientBrush& _this) -> D2D1_POINT_2F
{
    return _this.GetGradientOriginOffset();
}

auto ID2D1RadialGradientBrush_GetRadiusX(ID2D1RadialGradientBrush& _this) -> FLOAT
{
    return _this.GetRadiusX();
}

auto ID2D1RadialGradientBrush_GetRadiusY(ID2D1RadialGradientBrush& _this) -> FLOAT
{
    return _this.GetRadiusY();
}