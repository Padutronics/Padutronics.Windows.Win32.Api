#include "ID2D1Brush.hpp"

auto ID2D1Brush_GetOpacity(ID2D1Brush& _this) -> FLOAT
{
    return _this.GetOpacity();
}

void ID2D1Brush_GetTransform(ID2D1Brush& _this, D2D1_MATRIX_3X2_F* transform)
{
    _this.GetTransform(transform);
}

void ID2D1Brush_SetOpacity(ID2D1Brush& _this, FLOAT opacity)
{
    _this.SetOpacity(opacity);
}

void ID2D1Brush_SetTransform(ID2D1Brush& _this, const D2D1_MATRIX_3X2_F* transform)
{
    _this.SetTransform(transform);
}