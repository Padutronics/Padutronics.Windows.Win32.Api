#pragma once

#include "..\Configuration.hpp"

#include <dxgi.h>

EXPORT auto IDXGIFactory_EnumAdapters(IDXGIFactory& _this, UINT Adapter, IDXGIAdapter** ppAdapter) -> HRESULT;