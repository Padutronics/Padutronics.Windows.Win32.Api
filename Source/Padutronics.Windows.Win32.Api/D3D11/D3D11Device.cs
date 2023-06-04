using Padutronics.Windows.Win32.Api.D3D11.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.D3D11;

public class D3D11Device : Unknown, ID3D11Device
{
    public D3D11Device(nint pointer) :
        base(pointer)
    {
    }

    public void CreateRenderTargetView(ID3D11Resource pResource, D3D11_RENDER_TARGET_VIEW_DESC? pDesc, out ID3D11RenderTargetView ppRTView)
    {
        D3D11_RENDER_TARGET_VIEW_DESC pDescCopy;

        nint pDescPointer = nint.Zero;

        if (pDesc.HasValue)
        {
            pDescCopy = pDesc.Value;

            unsafe
            {
                pDescPointer = new nint(&pDescCopy);
            }
        }

        D3D11DeviceMethods.ID3D11Device_CreateRenderTargetView(This, pResource.Pointer, pDescPointer, out nint ppRTViewPointer);

        ppRTView = new D3D11RenderTargetView(ppRTViewPointer);
    }

    public void GetImmediateContext(out ID3D11DeviceContext ppImmediateContext)
    {
        D3D11DeviceMethods.ID3D11Device_GetImmediateContext(This, out nint ppImmediateContextPointer);

        ppImmediateContext = new D3D11DeviceContext(ppImmediateContextPointer);
    }
}