using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.DWrite.CWrapper;

internal static class DWriteFactoryMethods
{
    [DllImport(DllNames.CWrapper, CharSet = CharSet.Unicode, PreserveSig = false)]
    public static extern void IDWriteFactory_CreateTextFormat(IntPtr @this, string fontFamilyName, IntPtr fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, string localeName, out IntPtr textFormat);

    [DllImport(DllNames.CWrapper, CharSet = CharSet.Unicode, PreserveSig = false)]
    public static extern void IDWriteFactory_CreateTextLayout(IntPtr @this, string @string, int stringLength, IntPtr textFormat, float maxWidth, float maxHeight, out IntPtr textLayout);
}