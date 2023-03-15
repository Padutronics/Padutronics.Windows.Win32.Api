using Padutronics.Windows.Win32.Api.DxgiFormat;

namespace Padutronics.Windows.Win32.Api.DCommon;

public struct D2D1_PIXEL_FORMAT
{
    public DXGI_FORMAT format;
    public D2D1_ALPHA_MODE alphaMode;
}