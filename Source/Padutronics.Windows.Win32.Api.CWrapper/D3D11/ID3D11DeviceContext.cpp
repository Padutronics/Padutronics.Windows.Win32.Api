#include "ID3D11DeviceContext.hpp"

void ID3D11DeviceContext_ClearRenderTargetView(ID3D11DeviceContext& _this, ID3D11RenderTargetView* pRenderTargetView, const FLOAT ColorRGBA[4])
{
    _this.ClearRenderTargetView(pRenderTargetView, ColorRGBA);
}

void ID3D11DeviceContext_OMSetRenderTargets(ID3D11DeviceContext& _this, UINT NumViews, ID3D11RenderTargetView* const* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
{
    _this.OMSetRenderTargets(NumViews, ppRenderTargetViews, pDepthStencilView);
}

void ID3D11DeviceContext_RSSetViewports(ID3D11DeviceContext& _this, UINT NumViewports, const D3D11_VIEWPORT* pViewports)
{
    _this.RSSetViewports(NumViewports, pViewports);
}