using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1ResourceMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1Resource_GetFactory(nint @this, out nint factory);
}