using Padutronics.Interoperability;
using Padutronics.Windows.Win32.Api.D3D11.CWrapper;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11DeviceContext : D3D11DeviceChild, ID3D11DeviceContext
{
    public D3D11DeviceContext(nint pointer) :
        base(pointer)
    {
    }

    public void ClearRenderTargetView(ID3D11RenderTargetView pRenderTargetView, float[] ColorRGBA)
    {
        D3D11DeviceContextMethods.ID3D11DeviceContext_ClearRenderTargetView(This, pRenderTargetView.Pointer, ColorRGBA);
    }

    public void OMSetRenderTargets(int NumViews, ID3D11RenderTargetView[]? ppRenderTargetViews, ID3D11DepthStencilView? pDepthStencilView)
    {
        D3D11DeviceContextMethods.ID3D11DeviceContext_OMSetRenderTargets(This, NumViews, ppRenderTargetViews?.ToArrayOfPointers(), pDepthStencilView?.Pointer ?? nint.Zero);
    }

    public void RSSetViewports(int NumViewports, D3D11_VIEWPORT[]? pViewports)
    {
        D3D11DeviceContextMethods.ID3D11DeviceContext_RSSetViewports(This, NumViewports, pViewports);
    }
}