#pragma once

#include "..\Configuration.hpp"

#include <d3d11.h>

EXPORT void ID3D11DeviceContext_OMSetRenderTargets(ID3D11DeviceContext& _this, UINT NumViews, ID3D11RenderTargetView* const* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView);