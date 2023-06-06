using Padutronics.Windows.Win32.Api.DWrite.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteTextFormat : Unknown, IDWriteTextFormat
{
    public DWriteTextFormat(nint pointer) :
        base(pointer)
    {
    }

    public float GetFontSize()
    {
        return DWriteTextFormatMethods.IDWriteTextFormat_GetFontSize(This);
    }
}