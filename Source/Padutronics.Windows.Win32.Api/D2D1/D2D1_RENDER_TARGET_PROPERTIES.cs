using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public struct D2D1_RENDER_TARGET_PROPERTIES
{
    public D2D1_RENDER_TARGET_TYPE type;
    public D2D1_PIXEL_FORMAT pixelFormat;
    public float dpiX;
    public float dpiY;
    public D2D1_RENDER_TARGET_USAGE usage;
    public D2D1_FEATURE_LEVEL minLevel;
}