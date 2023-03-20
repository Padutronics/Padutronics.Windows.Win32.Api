using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D3D11;

[Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da")]
public interface ID3D11DeviceContext : ID3D11DeviceChild
{
    void ClearRenderTargetView(ID3D11RenderTargetView pRenderTargetView, float[] ColorRGBA);
    void OMSetRenderTargets(int NumViews, ID3D11RenderTargetView[]? ppRenderTargetViews, ID3D11DepthStencilView? pDepthStencilView);
    void RSSetViewports(int NumViewports, D3D11_VIEWPORT[]? pViewports);
}