#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1GradientStopCollection_GetExtendMode(ID2D1GradientStopCollection& _this) -> D2D1_EXTEND_MODE;
EXPORT auto ID2D1GradientStopCollection_GetGradientStopCount(ID2D1GradientStopCollection& _this) -> UINT32;