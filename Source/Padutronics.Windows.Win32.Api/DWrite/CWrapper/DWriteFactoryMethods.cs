using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.DWrite.CWrapper;

internal static class DWriteFactoryMethods
{
    [DllImport(DllNames.CWrapper, CharSet = CharSet.Unicode, PreserveSig = false)]
    public static extern void IDWriteFactory_CreateTextFormat(nint @this, string fontFamilyName, nint fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, string localeName, out nint textFormat);

    [DllImport(DllNames.CWrapper, CharSet = CharSet.Unicode, PreserveSig = false)]
    public static extern void IDWriteFactory_CreateTextLayout(nint @this, string @string, int stringLength, nint textFormat, float maxWidth, float maxHeight, out nint textLayout);
}