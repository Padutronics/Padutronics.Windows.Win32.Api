#include "ID2D1GeometryGroup.hpp"

auto ID2D1GeometryGroup_GetFillMode(ID2D1GeometryGroup& _this) -> D2D1_FILL_MODE
{
    return _this.GetFillMode();
}

void ID2D1GeometryGroup_GetSourceGeometries(ID2D1GeometryGroup& _this, ID2D1Geometry** geometries, UINT32 geometriesCount)
{
    _this.GetSourceGeometries(geometries, geometriesCount);
}

auto ID2D1GeometryGroup_GetSourceGeometryCount(ID2D1GeometryGroup& _this) -> UINT32
{
    return _this.GetSourceGeometryCount();
}