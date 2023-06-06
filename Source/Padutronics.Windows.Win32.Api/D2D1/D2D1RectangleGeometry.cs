using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1RectangleGeometry : D2D1Geometry, ID2D1RectangleGeometry
{
    public D2D1RectangleGeometry(nint pointer) :
        base(pointer)
    {
    }

    public void GetRect(out D2D_RECT_F rect)
    {
        D2D1RectangleGeometryMethods.ID2D1RectangleGeometry_GetRect(This, out rect);
    }
}