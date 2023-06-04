using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Dxgi.CWrapper;

internal static class DXGIFactoryMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IDXGIFactory_CreateSwapChain(nint @this, nint pDevice, ref DXGI_SWAP_CHAIN_DESC pDesc, out nint ppSwapChain);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IDXGIFactory_EnumAdapters(nint @this, int Adapter, out nint ppAdapter);
}