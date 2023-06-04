namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1GeometryGroup : D2D1Geometry, ID2D1GeometryGroup
{
    public D2D1GeometryGroup(nint pointer) :
        base(pointer)
    {
    }
}