#pragma once

#include "../Configuration.hpp"

#include <dxgi.h>

EXPORT auto IDXGISwapChain_GetBuffer(IDXGISwapChain& _this, UINT Buffer, REFIID riid, void** ppSurface) -> HRESULT;
EXPORT auto IDXGISwapChain_Present(IDXGISwapChain& _this, UINT SyncInterval, UINT Flags) -> HRESULT;
EXPORT auto IDXGISwapChain_ResizeBuffers(IDXGISwapChain& _this, UINT BufferCount, UINT Width, UINT Height, DXGI_FORMAT NewFormat, UINT SwapChainFlags) -> HRESULT;