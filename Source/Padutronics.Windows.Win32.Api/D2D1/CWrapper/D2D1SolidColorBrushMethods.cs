using Padutronics.Windows.Win32.Api.DxgiType;
using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1SolidColorBrushMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern D3DCOLORVALUE ID2D1SolidColorBrush_GetColor(IntPtr @this);
}