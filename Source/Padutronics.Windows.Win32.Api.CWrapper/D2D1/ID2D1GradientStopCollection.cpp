#include "ID2D1GradientStopCollection.hpp"

auto ID2D1GradientStopCollection_GetExtendMode(ID2D1GradientStopCollection& _this) -> D2D1_EXTEND_MODE
{
    return _this.GetExtendMode();
}

auto ID2D1GradientStopCollection_GetGradientStopCount(ID2D1GradientStopCollection& _this) -> UINT32
{
    return _this.GetGradientStopCount();
}