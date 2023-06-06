#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1RadialGradientBrush_GetCenter(ID2D1RadialGradientBrush& _this) -> D2D1_POINT_2F;
EXPORT auto ID2D1RadialGradientBrush_GetGradientOriginOffset(ID2D1RadialGradientBrush& _this) -> D2D1_POINT_2F;
EXPORT void ID2D1RadialGradientBrush_GetGradientStopCollection(ID2D1RadialGradientBrush& _this, ID2D1GradientStopCollection** gradientStopCollection);
EXPORT auto ID2D1RadialGradientBrush_GetRadiusX(ID2D1RadialGradientBrush& _this) -> FLOAT;
EXPORT auto ID2D1RadialGradientBrush_GetRadiusY(ID2D1RadialGradientBrush& _this) -> FLOAT;
EXPORT void ID2D1RadialGradientBrush_SetCenter(ID2D1RadialGradientBrush& _this, D2D1_POINT_2F center);
EXPORT void ID2D1RadialGradientBrush_SetGradientOriginOffset(ID2D1RadialGradientBrush& _this, D2D1_POINT_2F gradientOriginOffset);
EXPORT void ID2D1RadialGradientBrush_SetRadiusX(ID2D1RadialGradientBrush& _this, FLOAT radiusX);