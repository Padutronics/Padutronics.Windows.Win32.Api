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

    public void GetSourceGeometries(nint @this, ID2D1Geometry?[] geometries, int geometriesCount)
    {
        var geometryPointers = new nint[geometries.Length];

        D2D1GeometryGroupMethods.ID2D1GeometryGroup_GetSourceGeometries(This, geometryPointers, geometriesCount);

        for (var geometryIndex = 0; geometryIndex < geometries.Length; ++geometryIndex)
        {
            nint geometryPointer = geometryPointers[geometryIndex];

            geometries[geometryIndex] = geometryPointer == nint.Zero ? null : new D2D1Geometry(geometryPointer);
        }
    }

    public int GetSourceGeometryCount()
    {
        return D2D1GeometryGroupMethods.ID2D1GeometryGroup_GetSourceGeometryCount(This);
    }
}