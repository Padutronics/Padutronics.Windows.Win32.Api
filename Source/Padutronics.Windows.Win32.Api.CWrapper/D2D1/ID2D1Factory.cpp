#include "ID2D1Factory.hpp"

auto ID2D1Factory_CreateDxgiSurfaceRenderTarget(ID2D1Factory& _this, IDXGISurface* dxgiSurface, const D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget) -> HRESULT
{
    return _this.CreateDxgiSurfaceRenderTarget(dxgiSurface, renderTargetProperties, renderTarget);
}