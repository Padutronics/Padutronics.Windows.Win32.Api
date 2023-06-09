using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1GeometryGroupMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_FILL_MODE ID2D1GeometryGroup_GetFillMode(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1GeometryGroup_GetSourceGeometries(nint @this, nint[] geometries, int geometriesCount);

    [DllImport(DllNames.CWrapper)]
    public static extern int ID2D1GeometryGroup_GetSourceGeometryCount(nint @this);
}