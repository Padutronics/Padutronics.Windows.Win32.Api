#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1Brush_GetOpacity(ID2D1Brush& _this) -> FLOAT;
EXPORT void ID2D1Brush_GetTransform(ID2D1Brush& _this, D2D1_MATRIX_3X2_F* transform);
EXPORT void ID2D1Brush_SetOpacity(ID2D1Brush& _this, FLOAT opacity);
EXPORT void ID2D1Brush_SetTransform(ID2D1Brush& _this, const D2D1_MATRIX_3X2_F* transform);