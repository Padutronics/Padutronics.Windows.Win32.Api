using Padutronics.Windows.Win32.Api.D2D1.CWrapper;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1StrokeStyle : D2D1Resource, ID2D1StrokeStyle
{
    public D2D1StrokeStyle(nint pointer) :
        base(pointer)
    {
    }

    public D2D1_CAP_STYLE GetDashCap()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetDashCap(This);
    }

    public int GetDashesCount()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetDashesCount(This);
    }

    public float GetDashOffset()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetDashOffset(This);
    }

    public D2D1_DASH_STYLE GetDashStyle()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetDashStyle(This);
    }

    public D2D1_CAP_STYLE GetEndCap()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetEndCap(This);
    }

    public D2D1_LINE_JOIN GetLineJoin()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetLineJoin(This);
    }

    public float GetMiterLimit()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetMiterLimit(This);
    }

    public D2D1_CAP_STYLE GetStartCap()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetStartCap(This);
    }
}