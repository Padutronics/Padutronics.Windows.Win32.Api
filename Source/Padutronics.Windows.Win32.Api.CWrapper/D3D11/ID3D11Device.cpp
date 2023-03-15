#include "ID3D11Device.hpp"

auto ID3D11Device_CreateRenderTargetView(ID3D11Device& _this, ID3D11Resource* pResource, const D3D11_RENDER_TARGET_VIEW_DESC* pDesc, ID3D11RenderTargetView** ppRTView) -> HRESULT
{
    return _this.CreateRenderTargetView(pResource, pDesc, ppRTView);
}

void ID3D11Device_GetImmediateContext(ID3D11Device& _this, ID3D11DeviceContext** ppImmediateContext)
{
    _this.GetImmediateContext(ppImmediateContext);
}