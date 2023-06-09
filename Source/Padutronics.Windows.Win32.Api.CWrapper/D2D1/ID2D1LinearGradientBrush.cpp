#include "ID2D1LinearGradientBrush.hpp"

auto ID2D1LinearGradientBrush_GetEndPoint(ID2D1LinearGradientBrush& _this) -> D2D1_POINT_2F
{
    return _this.GetEndPoint();
}

void ID2D1LinearGradientBrush_GetGradientStopCollection(ID2D1LinearGradientBrush& _this, ID2D1GradientStopCollection** gradientStopCollection)
{
    _this.GetGradientStopCollection(gradientStopCollection);
}

auto ID2D1LinearGradientBrush_GetStartPoint(ID2D1LinearGradientBrush& _this) -> D2D1_POINT_2F
{
    return _this.GetStartPoint();
}

void ID2D1LinearGradientBrush_SetEndPoint(ID2D1LinearGradientBrush& _this, D2D1_POINT_2F endPoint)
{
    _this.SetEndPoint(endPoint);
}

void ID2D1LinearGradientBrush_SetStartPoint(ID2D1LinearGradientBrush& _this, D2D1_POINT_2F startPoint)
{
    _this.SetStartPoint(startPoint);
}