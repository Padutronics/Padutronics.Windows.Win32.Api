#include "ID2D1Geometry.hpp"

auto ID2D1Geometry_CombineWithGeometry(ID2D1Geometry& _this, ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, const D2D1_MATRIX_3X2_F* inputGeometryTransform, FLOAT flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink) -> HRESULT
{
    return _this.CombineWithGeometry(inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
}