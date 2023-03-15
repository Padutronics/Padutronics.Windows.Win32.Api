#pragma once

#include "..\Configuration.hpp"

#include <dxgi.h>

EXPORT auto IDXGIFactory_CreateSwapChain(IDXGIFactory& _this, IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain) -> HRESULT;
EXPORT auto IDXGIFactory_EnumAdapters(IDXGIFactory& _this, UINT Adapter, IDXGIAdapter** ppAdapter) -> HRESULT;