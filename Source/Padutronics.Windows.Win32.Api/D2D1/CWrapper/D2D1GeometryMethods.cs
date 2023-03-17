using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1GeometryMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Geometry_CombineWithGeometry(IntPtr @this, IntPtr inputGeometry, D2D1_COMBINE_MODE combineMode, IntPtr inputGeometryTransform, float flatteningTolerance, IntPtr geometrySink);
}