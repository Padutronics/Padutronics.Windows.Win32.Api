using System.Runtime.InteropServices;
using System.Text;

namespace Padutronics.Windows.Win32.Api.DWrite.CWrapper;

internal static class DWriteTextFormatMethods
{
    [DllImport(DllNames.CWrapper, CharSet = CharSet.Unicode, PreserveSig = false)]
    public static extern void IDWriteTextFormat_GetFontFamilyName(nint @this, StringBuilder fontFamilyName, int nameSize);

    [DllImport(DllNames.CWrapper)]
    public static extern int IDWriteTextFormat_GetFontFamilyNameLength(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern float IDWriteTextFormat_GetFontSize(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern DWRITE_FONT_STRETCH IDWriteTextFormat_GetFontStretch(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern DWRITE_FONT_STYLE IDWriteTextFormat_GetFontStyle(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern DWRITE_FONT_WEIGHT IDWriteTextFormat_GetFontWeight(nint @this);
}