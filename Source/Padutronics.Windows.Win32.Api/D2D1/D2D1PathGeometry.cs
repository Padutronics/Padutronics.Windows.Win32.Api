using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1PathGeometry : D2D1Geometry, ID2D1PathGeometry
{
    public D2D1PathGeometry(nint pointer) :
        base(pointer)
    {
    }

    public void Open(out ID2D1GeometrySink geometrySink)
    {
        D2D1PathGeometryMethods.ID2D1PathGeometry_Open(This, out nint geometrySinkPointer);

        geometrySink = new D2D1GeometrySink(geometrySinkPointer);
    }
}