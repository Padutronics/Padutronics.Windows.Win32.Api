using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1BrushMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern float ID2D1Brush_GetOpacity(nint @this);
}