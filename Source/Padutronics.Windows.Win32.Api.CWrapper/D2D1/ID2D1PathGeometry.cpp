#include "ID2D1PathGeometry.hpp"

auto ID2D1PathGeometry_Open(ID2D1PathGeometry& _this, ID2D1GeometrySink** geometrySink) -> HRESULT
{
    return _this.Open(geometrySink);
}