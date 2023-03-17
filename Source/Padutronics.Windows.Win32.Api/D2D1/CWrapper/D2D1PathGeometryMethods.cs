using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1PathGeometryMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1PathGeometry_Open(IntPtr @this, out IntPtr geometrySink);
}