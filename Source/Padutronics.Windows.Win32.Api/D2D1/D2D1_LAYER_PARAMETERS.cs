using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public struct D2D1_LAYER_PARAMETERS
{
    public D2D_RECT_F contentBounds;
    public nint geometricMask;
    public D2D1_ANTIALIAS_MODE maskAntialiasMode;
    public D2D_MATRIX_3X2_F maskTransform;
    public float opacity;
    public nint opacityBrush;
    public D2D1_LAYER_OPTIONS layerOptions;
}