#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1SolidColorBrush_GetColor(ID2D1SolidColorBrush& _this) -> D2D1_COLOR_F;
EXPORT void ID2D1SolidColorBrush_SetColor(ID2D1SolidColorBrush& _this, const D2D1_COLOR_F* color);