#include "IDXGISwapChain.hpp"

auto IDXGISwapChain_GetBuffer(IDXGISwapChain& _this, UINT Buffer, REFIID riid, void** ppSurface) -> HRESULT
{
    return _this.GetBuffer(Buffer, riid, ppSurface);
}

auto IDXGISwapChain_Present(IDXGISwapChain& _this, UINT SyncInterval, UINT Flags) -> HRESULT
{
    return _this.Present(SyncInterval, Flags);
}

auto IDXGISwapChain_ResizeBuffers(IDXGISwapChain& _this, UINT BufferCount, UINT Width, UINT Height, DXGI_FORMAT NewFormat, UINT SwapChainFlags) -> HRESULT
{
    return _this.ResizeBuffers(BufferCount, Width, Height, NewFormat, SwapChainFlags);
}