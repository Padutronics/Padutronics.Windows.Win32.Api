#include "IDXGISwapChain.hpp"

auto IDXGISwapChain_GetBuffer(IDXGISwapChain& _this, UINT Buffer, REFIID riid, void** ppSurface) -> HRESULT
{
    return _this.GetBuffer(Buffer, riid, ppSurface);
}

auto IDXGISwapChain_Present(IDXGISwapChain& _this, UINT SyncInterval, UINT Flags) -> HRESULT
{
    return _this.Present(SyncInterval, Flags);
}