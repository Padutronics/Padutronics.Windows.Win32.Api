#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1StrokeStyle_GetDashCap(ID2D1StrokeStyle& _this) -> D2D1_CAP_STYLE;
EXPORT auto ID2D1StrokeStyle_GetDashOffset(ID2D1StrokeStyle& _this) -> FLOAT;
EXPORT auto ID2D1StrokeStyle_GetDashStyle(ID2D1StrokeStyle& _this) -> D2D1_DASH_STYLE;
EXPORT auto ID2D1StrokeStyle_GetDashesCount(ID2D1StrokeStyle& _this) -> UINT32;
EXPORT auto ID2D1StrokeStyle_GetEndCap(ID2D1StrokeStyle& _this) -> D2D1_CAP_STYLE;
EXPORT auto ID2D1StrokeStyle_GetLineJoin(ID2D1StrokeStyle& _this) -> D2D1_LINE_JOIN;
EXPORT auto ID2D1StrokeStyle_GetMiterLimit(ID2D1StrokeStyle& _this) -> FLOAT;
EXPORT auto ID2D1StrokeStyle_GetStartCap(ID2D1StrokeStyle& _this) -> D2D1_CAP_STYLE;