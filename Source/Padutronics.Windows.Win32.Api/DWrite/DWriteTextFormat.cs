using Padutronics.Windows.Win32.Api.DWrite.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;
using System.Text;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteTextFormat : Unknown, IDWriteTextFormat
{
    public DWriteTextFormat(nint pointer) :
        base(pointer)
    {
    }

    public void GetFontFamilyName(StringBuilder fontFamilyName, int nameSize)
    {
        DWriteTextFormatMethods.IDWriteTextFormat_GetFontFamilyName(This, fontFamilyName, nameSize);
    }

    public int GetFontFamilyNameLength()
    {
        return DWriteTextFormatMethods.IDWriteTextFormat_GetFontFamilyNameLength(This);
    }

    public float GetFontSize()
    {
        return DWriteTextFormatMethods.IDWriteTextFormat_GetFontSize(This);
    }

    public DWRITE_FONT_STRETCH GetFontStretch()
    {
        return DWriteTextFormatMethods.IDWriteTextFormat_GetFontStretch(This);
    }

    public DWRITE_FONT_STYLE GetFontStyle()
    {
        return DWriteTextFormatMethods.IDWriteTextFormat_GetFontStyle(This);
    }

    public DWRITE_FONT_WEIGHT GetFontWeight()
    {
        return DWriteTextFormatMethods.IDWriteTextFormat_GetFontWeight(This);
    }
}