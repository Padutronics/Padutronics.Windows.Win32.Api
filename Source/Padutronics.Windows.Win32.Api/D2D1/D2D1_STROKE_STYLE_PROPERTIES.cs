namespace Padutronics.Windows.Win32.Api.D2D1;

public struct D2D1_STROKE_STYLE_PROPERTIES
{
    public D2D1_CAP_STYLE startCap;
    public D2D1_CAP_STYLE endCap;
    public D2D1_CAP_STYLE dashCap;
    public D2D1_LINE_JOIN lineJoin;
    public float miterLimit;
    public D2D1_DASH_STYLE dashStyle;
    public float dashOffset;
}