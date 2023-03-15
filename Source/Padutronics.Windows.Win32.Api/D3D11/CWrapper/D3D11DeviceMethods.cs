using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D3D11.CWrapper;

internal static class D3D11DeviceMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID3D11Device_CreateRenderTargetView(IntPtr @this, IntPtr pResource, IntPtr pDesc, out IntPtr ppRTView);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID3D11Device_GetImmediateContext(IntPtr @this, out IntPtr ppImmediateContext);
}