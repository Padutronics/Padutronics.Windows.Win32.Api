using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D3D11.CWrapper;

internal static class D3D11DeviceContextMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID3D11DeviceContext_OMSetRenderTargets(IntPtr @this, int NumViews, IntPtr[]? ppRenderTargetViews, IntPtr pDepthStencilView);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID3D11DeviceContext_RSSetViewports(IntPtr @this, int NumViewports, D3D11_VIEWPORT[]? pViewports);
}