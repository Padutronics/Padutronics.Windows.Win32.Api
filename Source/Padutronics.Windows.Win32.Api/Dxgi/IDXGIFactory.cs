using Padutronics.Windows.Win32.Api.Unknwn;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Dxgi;

[Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
public interface IDXGIFactory : IDXGIObject
{
    void CreateSwapChain(IUnknown pDevice, DXGI_SWAP_CHAIN_DESC pDesc, out IDXGISwapChain ppSwapChain);
    void EnumAdapters(int Adapter, out IDXGIAdapter ppAdapter);
}