#pragma once

#include "../Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1GeometryGroup_GetFillMode(ID2D1GeometryGroup& _this) -> D2D1_FILL_MODE;
EXPORT void ID2D1GeometryGroup_GetSourceGeometries(ID2D1GeometryGroup& _this, ID2D1Geometry** geometries, UINT32 geometriesCount);
EXPORT auto ID2D1GeometryGroup_GetSourceGeometryCount(ID2D1GeometryGroup& _this) -> UINT32;