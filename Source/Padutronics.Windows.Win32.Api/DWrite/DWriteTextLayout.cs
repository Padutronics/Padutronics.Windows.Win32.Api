namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteTextLayout : DWriteTextFormat, IDWriteTextLayout
{
    public DWriteTextLayout(nint pointer) :
        base(pointer)
    {
    }
}