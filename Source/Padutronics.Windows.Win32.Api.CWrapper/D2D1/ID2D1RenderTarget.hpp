#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT void ID2D1RenderTarget_BeginDraw(ID2D1RenderTarget& _this);
EXPORT auto ID2D1RenderTarget_CreateSolidColorBrush(ID2D1RenderTarget& _this, const D2D1_COLOR_F* color, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush) -> HRESULT;
EXPORT auto ID2D1RenderTarget_EndDraw(ID2D1RenderTarget& _this, D2D1_TAG* tag1, D2D1_TAG* tag2) -> HRESULT;