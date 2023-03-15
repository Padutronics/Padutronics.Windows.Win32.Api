using Padutronics.Windows.Win32.Api.DxgiCommon;
using Padutronics.Windows.Win32.Api.DxgiFormat;
using Padutronics.Windows.Win32.Api.DxgiType;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public struct DXGI_MODE_DESC
{
    public int Width;
    public int Height;
    public DXGI_RATIONAL RefreshRate;
    public DXGI_FORMAT Format;
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
    public DXGI_MODE_SCALING Scaling;
}