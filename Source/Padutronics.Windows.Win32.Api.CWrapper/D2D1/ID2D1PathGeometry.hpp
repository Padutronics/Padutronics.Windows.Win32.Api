#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1PathGeometry_Open(ID2D1PathGeometry& _this, ID2D1GeometrySink** geometrySink) -> HRESULT;