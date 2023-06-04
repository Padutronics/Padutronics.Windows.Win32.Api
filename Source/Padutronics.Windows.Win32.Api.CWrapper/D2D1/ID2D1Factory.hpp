#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT auto ID2D1Factory_CreateDxgiSurfaceRenderTarget(ID2D1Factory& _this, IDXGISurface* dxgiSurface, const D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget) -> HRESULT;
EXPORT auto ID2D1Factory_CreateEllipseGeometry(ID2D1Factory& _this, const D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry) -> HRESULT;
EXPORT auto ID2D1Factory_CreateGeometryGroup(ID2D1Factory& _this, D2D1_FILL_MODE fillMode, ID2D1Geometry** geometries, UINT32 geometriesCount, ID2D1GeometryGroup** geometryGroup) -> HRESULT;
EXPORT auto ID2D1Factory_CreatePathGeometry(ID2D1Factory& _this, ID2D1PathGeometry** pathGeometry) -> HRESULT;
EXPORT auto ID2D1Factory_CreateRectangleGeometry(ID2D1Factory& _this, const D2D1_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry) -> HRESULT;
EXPORT auto ID2D1Factory_CreateStrokeStyle(ID2D1Factory& _this, const D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, const FLOAT* dashes, UINT32 dashesCount, ID2D1StrokeStyle** strokeStyle) -> HRESULT;