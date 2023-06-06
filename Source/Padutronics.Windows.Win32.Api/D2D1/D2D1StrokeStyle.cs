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

    public float GetDashOffset()
    {
        return D2D1StrokeStyleMethods.ID2D1StrokeStyle_GetDashOffset(This);
    }
}