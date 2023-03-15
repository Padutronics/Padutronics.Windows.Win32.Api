#include "IDXGIFactory.hpp"

auto IDXGIFactory_EnumAdapters(IDXGIFactory& _this, UINT Adapter, IDXGIAdapter** ppAdapter) -> HRESULT
{
    return _this.EnumAdapters(Adapter, ppAdapter);
}