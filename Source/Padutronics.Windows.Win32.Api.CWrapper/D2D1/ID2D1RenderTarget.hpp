#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT void ID2D1RenderTarget_BeginDraw(ID2D1RenderTarget& _this);
EXPORT auto ID2D1RenderTarget_CreateGradientStopCollection(ID2D1RenderTarget& _this, const D2D1_GRADIENT_STOP* gradientStops, UINT32 gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateLinearGradientBrush(ID2D1RenderTarget& _this, const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateRadialGradientBrush(ID2D1RenderTarget& _this, const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateSolidColorBrush(ID2D1RenderTarget& _this, const D2D1_COLOR_F* color, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush) -> HRESULT;
EXPORT auto ID2D1RenderTarget_EndDraw(ID2D1RenderTarget& _this, D2D1_TAG* tag1, D2D1_TAG* tag2) -> HRESULT;