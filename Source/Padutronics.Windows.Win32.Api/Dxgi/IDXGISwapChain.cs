using Padutronics.Windows.Win32.Api.DxgiFormat;
using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Dxgi;

[Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
public interface IDXGISwapChain : IDXGIDeviceSubObject
{
    void GetBuffer(int Buffer, Guid riid, out nint ppSurface);
    void Present(int SyncInterval, DXGI_PRESENT Flags);
    void ResizeBuffers(int BufferCount, int Width, int Height, DXGI_FORMAT NewFormat, DXGI_SWAP_CHAIN_FLAG SwapChainFlags);
}