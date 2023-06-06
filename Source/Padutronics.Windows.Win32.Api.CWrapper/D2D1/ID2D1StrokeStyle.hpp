#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1StrokeStyle_GetDashCap(ID2D1StrokeStyle& _this) -> D2D1_CAP_STYLE;
EXPORT auto ID2D1StrokeStyle_GetDashOffset(ID2D1StrokeStyle& _this) -> FLOAT;