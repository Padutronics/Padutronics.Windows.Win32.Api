using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1EllipseGeometry : D2D1Geometry, ID2D1EllipseGeometry
{
    public D2D1EllipseGeometry(IntPtr pointer) :
        base(pointer)
    {
    }
}