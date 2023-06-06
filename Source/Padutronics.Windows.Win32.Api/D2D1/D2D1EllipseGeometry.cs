using Padutronics.Windows.Win32.Api.D2D1.CWrapper;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1EllipseGeometry : D2D1Geometry, ID2D1EllipseGeometry
{
    public D2D1EllipseGeometry(nint pointer) :
        base(pointer)
    {
    }

    public void GetEllipse(out D2D1_ELLIPSE ellipse)
    {
        D2D1EllipseGeometryMethods.ID2D1EllipseGeometry_GetEllipse(This, out ellipse);
    }
}