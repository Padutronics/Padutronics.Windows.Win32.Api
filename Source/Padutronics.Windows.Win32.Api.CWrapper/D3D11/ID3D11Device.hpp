#pragma once

#include "..\Configuration.hpp"

#include <d3d11.h>

EXPORT auto ID3D11Device_CreateRenderTargetView(ID3D11Device& _this, ID3D11Resource* pResource, const D3D11_RENDER_TARGET_VIEW_DESC* pDesc, ID3D11RenderTargetView** ppRTView) -> HRESULT;
EXPORT void ID3D11Device_GetImmediateContext(ID3D11Device& _this, ID3D11DeviceContext** ppImmediateContext);