#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1Factory_CreateDxgiSurfaceRenderTarget(ID2D1Factory& _this, IDXGISurface* dxgiSurface, const D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget) -> HRESULT;
EXPORT auto ID2D1Factory_CreatePathGeometry(ID2D1Factory& _this, ID2D1PathGeometry** pathGeometry) -> HRESULT;
EXPORT auto ID2D1Factory_CreateStrokeStyle(ID2D1Factory& _this, const D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, const FLOAT* dashes, UINT32 dashesCount, ID2D1StrokeStyle** strokeStyle) -> HRESULT;