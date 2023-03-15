#include "IDXGISwapChain.hpp"

auto IDXGISwapChain_GetBuffer(IDXGISwapChain& _this, UINT Buffer, REFIID riid, void** ppSurface) -> HRESULT
{
    return _this.GetBuffer(Buffer, riid, ppSurface);
}