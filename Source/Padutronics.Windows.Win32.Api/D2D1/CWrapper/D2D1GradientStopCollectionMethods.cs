using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1GradientStopCollectionMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_EXTEND_MODE ID2D1GradientStopCollection_GetExtendMode(nint @this);
}