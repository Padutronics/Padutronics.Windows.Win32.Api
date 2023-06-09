#include "ID2D1Factory.hpp"

auto ID2D1Factory_CreateDxgiSurfaceRenderTarget(ID2D1Factory& _this, IDXGISurface* dxgiSurface, const D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget) -> HRESULT
{
    return _this.CreateDxgiSurfaceRenderTarget(dxgiSurface, renderTargetProperties, renderTarget);
}

auto ID2D1Factory_CreateEllipseGeometry(ID2D1Factory& _this, const D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry) -> HRESULT
{
    return _this.CreateEllipseGeometry(ellipse, ellipseGeometry);
}

auto ID2D1Factory_CreateGeometryGroup(ID2D1Factory& _this, D2D1_FILL_MODE fillMode, ID2D1Geometry** geometries, UINT32 geometriesCount, ID2D1GeometryGroup** geometryGroup) -> HRESULT
{
    return _this.CreateGeometryGroup(fillMode, geometries, geometriesCount, geometryGroup);
}

auto ID2D1Factory_CreatePathGeometry(ID2D1Factory& _this, ID2D1PathGeometry** pathGeometry) -> HRESULT
{
    return _this.CreatePathGeometry(pathGeometry);
}

auto ID2D1Factory_CreateRectangleGeometry(ID2D1Factory& _this, const D2D1_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry) -> HRESULT
{
    return _this.CreateRectangleGeometry(rectangle, rectangleGeometry);
}

auto ID2D1Factory_CreateStrokeStyle(ID2D1Factory& _this, const D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, const FLOAT* dashes, UINT32 dashesCount, ID2D1StrokeStyle** strokeStyle) -> HRESULT
{
    return _this.CreateStrokeStyle(strokeStyleProperties, dashes, dashesCount, strokeStyle);
}