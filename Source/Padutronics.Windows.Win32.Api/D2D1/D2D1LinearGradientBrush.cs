using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1LinearGradientBrush : D2D1Brush, ID2D1LinearGradientBrush
{
    public D2D1LinearGradientBrush(nint pointer) :
        base(pointer)
    {
    }

    public D2D_POINT_2F GetEndPoint()
    {
        return D2D1LinearGradientBrushMethods.ID2D1LinearGradientBrush_GetEndPoint(This);
    }

    public D2D_POINT_2F GetStartPoint()
    {
        return D2D1LinearGradientBrushMethods.ID2D1LinearGradientBrush_GetStartPoint(This);
    }
}