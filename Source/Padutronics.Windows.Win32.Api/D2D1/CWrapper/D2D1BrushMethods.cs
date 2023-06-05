using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1BrushMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern float ID2D1Brush_GetOpacity(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1Brush_GetTransform(nint @this, out D2D_MATRIX_3X2_F transform);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1Brush_SetOpacity(nint @this, float opacity);
}