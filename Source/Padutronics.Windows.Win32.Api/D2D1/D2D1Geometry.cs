using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Geometry : D2D1Resource, ID2D1Geometry
{
    public D2D1Geometry(IntPtr pointer) :
        base(pointer)
    {
    }
}