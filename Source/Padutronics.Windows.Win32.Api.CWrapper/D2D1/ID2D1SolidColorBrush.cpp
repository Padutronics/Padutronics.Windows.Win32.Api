#include "ID2D1SolidColorBrush.hpp"

auto ID2D1SolidColorBrush_GetColor(ID2D1SolidColorBrush& _this) -> D2D1_COLOR_F
{
    return _this.GetColor();
}