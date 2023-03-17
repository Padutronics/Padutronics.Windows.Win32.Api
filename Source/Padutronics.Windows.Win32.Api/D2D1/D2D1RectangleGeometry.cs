using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1RectangleGeometry : D2D1Geometry, ID2D1RectangleGeometry
{
    public D2D1RectangleGeometry(IntPtr pointer) :
        base(pointer)
    {
    }
}