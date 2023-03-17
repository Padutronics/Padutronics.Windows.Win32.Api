using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1GeometrySink : D2D1SimplifiedGeometrySink, ID2D1GeometrySink
{
    public D2D1GeometrySink(IntPtr pointer) :
        base(pointer)
    {
    }
}