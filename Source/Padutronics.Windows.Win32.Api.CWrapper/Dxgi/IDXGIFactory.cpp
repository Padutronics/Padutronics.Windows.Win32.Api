#include "IDXGIFactory.hpp"

auto IDXGIFactory_CreateSwapChain(IDXGIFactory& _this, IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain) -> HRESULT
{
    return _this.CreateSwapChain(pDevice, pDesc, ppSwapChain);
}

auto IDXGIFactory_EnumAdapters(IDXGIFactory& _this, UINT Adapter, IDXGIAdapter** ppAdapter) -> HRESULT
{
    return _this.EnumAdapters(Adapter, ppAdapter);
}