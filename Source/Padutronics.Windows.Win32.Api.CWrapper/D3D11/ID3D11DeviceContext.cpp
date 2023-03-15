#include "ID3D11DeviceContext.hpp"

void ID3D11DeviceContext_OMSetRenderTargets(ID3D11DeviceContext& _this, UINT NumViews, ID3D11RenderTargetView* const* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
{
    _this.OMSetRenderTargets(NumViews, ppRenderTargetViews, pDepthStencilView);
}