#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1LinearGradientBrush_GetEndPoint(ID2D1LinearGradientBrush& _this) -> D2D1_POINT_2F;
EXPORT auto ID2D1LinearGradientBrush_GetStartPoint(ID2D1LinearGradientBrush& _this) -> D2D1_POINT_2F;
EXPORT void ID2D1LinearGradientBrush_SetEndPoint(ID2D1LinearGradientBrush& _this, D2D1_POINT_2F endPoint);