using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D3D11.CWrapper;

internal static class D3D11DeviceContextMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID3D11DeviceContext_ClearRenderTargetView(nint @this, nint pRenderTargetView, [MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] float[] ColorRGBA);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID3D11DeviceContext_OMSetRenderTargets(nint @this, int NumViews, nint[]? ppRenderTargetViews, nint pDepthStencilView);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID3D11DeviceContext_RSSetViewports(nint @this, int NumViewports, D3D11_VIEWPORT[]? pViewports);
}