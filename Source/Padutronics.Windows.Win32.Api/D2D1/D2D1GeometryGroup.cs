using Padutronics.Windows.Win32.Api.D2D1.CWrapper;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1GeometryGroup : D2D1Geometry, ID2D1GeometryGroup
{
    public D2D1GeometryGroup(nint pointer) :
        base(pointer)
    {
    }

    public D2D1_FILL_MODE GetFillMode()
    {
        return D2D1GeometryGroupMethods.ID2D1GeometryGroup_GetFillMode(This);
    }
}