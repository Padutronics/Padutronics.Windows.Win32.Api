using Padutronics.Windows.Win32.Api.DxgiFormat;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D3D11;

[StructLayout(LayoutKind.Explicit)]
public struct D3D11_RENDER_TARGET_VIEW_DESC
{
    [FieldOffset(0)]
    public DXGI_FORMAT Format;
    [FieldOffset(4)]
    public D3D11_RTV_DIMENSION ViewDimension;
    [FieldOffset(8)]
    public D3D11_BUFFER_RTV Buffer;
    [FieldOffset(8)]
    public D3D11_TEX1D_RTV Texture1D;
    [FieldOffset(8)]
    public D3D11_TEX1D_ARRAY_RTV Texture1DArray;
    [FieldOffset(8)]
    public D3D11_TEX2D_RTV Texture2D;
    [FieldOffset(8)]
    public D3D11_TEX2D_ARRAY_RTV Texture2DArray;
    [FieldOffset(8)]
    public D3D11_TEX2DMS_RTV Texture2DMS;
    [FieldOffset(8)]
    public D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray;
    [FieldOffset(8)]
    public D3D11_TEX3D_RTV Texture3D;
}