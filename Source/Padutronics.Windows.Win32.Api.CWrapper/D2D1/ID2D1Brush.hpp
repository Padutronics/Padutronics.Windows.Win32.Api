#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1Brush_GetOpacity(ID2D1Brush& _this) -> FLOAT;
EXPORT void ID2D1Brush_GetTransform(ID2D1Brush& _this, D2D1_MATRIX_3X2_F* transform);