#pragma once

#include "..\Configuration.hpp"

#include <dxgi.h>

EXPORT auto IDXGISwapChain_GetBuffer(IDXGISwapChain& _this, UINT Buffer, REFIID riid, void** ppSurface) -> HRESULT;