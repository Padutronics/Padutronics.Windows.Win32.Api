using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1RadialGradientBrush : D2D1Brush, ID2D1RadialGradientBrush
{
    public D2D1RadialGradientBrush(nint pointer) :
        base(pointer)
    {
    }

    public D2D_POINT_2F GetCenter()
    {
        return D2D1RadialGradientBrushMethods.ID2D1RadialGradientBrush_GetCenter(This);
    }
}