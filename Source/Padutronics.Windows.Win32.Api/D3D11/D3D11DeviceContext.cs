using Padutronics.Interoperability;
using Padutronics.Windows.Win32.Api.D3D11.CWrapper;
using System;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11DeviceContext : D3D11DeviceChild, ID3D11DeviceContext
{
    public D3D11DeviceContext(IntPtr pointer) :
        base(pointer)
    {
    }

    public void OMSetRenderTargets(int NumViews, ID3D11RenderTargetView[]? ppRenderTargetViews, ID3D11DepthStencilView? pDepthStencilView)
    {
        D3D11DeviceContextMethods.ID3D11DeviceContext_OMSetRenderTargets(This, NumViews, ppRenderTargetViews?.ToArrayOfPointers(), pDepthStencilView?.Pointer ?? IntPtr.Zero);
    }
}