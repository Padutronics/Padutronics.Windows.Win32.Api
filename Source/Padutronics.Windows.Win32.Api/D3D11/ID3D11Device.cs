using Padutronics.Windows.Win32.Api.Unknwn;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D3D11;

[Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140")]
public interface ID3D11Device : IUnknown
{
    void CreateRenderTargetView(ID3D11Resource pResource, D3D11_RENDER_TARGET_VIEW_DESC? pDesc, out ID3D11RenderTargetView ppRTView);
    void GetImmediateContext(out ID3D11DeviceContext ppImmediateContext);
}