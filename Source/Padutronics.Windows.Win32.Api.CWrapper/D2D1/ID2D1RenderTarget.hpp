#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT void ID2D1RenderTarget_BeginDraw(ID2D1RenderTarget& _this);
EXPORT auto ID2D1RenderTarget_EndDraw(ID2D1RenderTarget& _this, D2D1_TAG* tag1, D2D1_TAG* tag2) -> HRESULT;