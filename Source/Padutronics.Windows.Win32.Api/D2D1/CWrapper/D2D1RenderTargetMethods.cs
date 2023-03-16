using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1RenderTargetMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_BeginDraw(IntPtr @this);
}