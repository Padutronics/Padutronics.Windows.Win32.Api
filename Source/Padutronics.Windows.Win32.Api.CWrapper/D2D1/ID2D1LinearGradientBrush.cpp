#include "ID2D1LinearGradientBrush.hpp"

auto ID2D1LinearGradientBrush_GetEndPoint(ID2D1LinearGradientBrush& _this) -> D2D1_POINT_2F
{
    return _this.GetEndPoint();
}

auto ID2D1LinearGradientBrush_GetStartPoint(ID2D1LinearGradientBrush& _this) -> D2D1_POINT_2F
{
    return _this.GetStartPoint();
}

void ID2D1LinearGradientBrush_SetEndPoint(ID2D1LinearGradientBrush& _this, D2D1_POINT_2F endPoint)
{
    _this.SetEndPoint(endPoint);
}