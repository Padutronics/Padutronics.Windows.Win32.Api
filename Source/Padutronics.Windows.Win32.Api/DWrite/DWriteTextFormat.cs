using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteTextFormat : Unknown, IDWriteTextFormat
{
    public DWriteTextFormat(nint pointer) :
        base(pointer)
    {
    }
}