using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1PathGeometry : D2D1Geometry, ID2D1PathGeometry
{
    public D2D1PathGeometry(IntPtr pointer) :
        base(pointer)
    {
    }
}