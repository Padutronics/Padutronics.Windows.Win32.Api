using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.DWrite.CWrapper;

internal static class DWriteTextLayoutMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IDWriteTextLayout_GetMetrics(IntPtr @this, out DWRITE_TEXT_METRICS textMetrics);
}