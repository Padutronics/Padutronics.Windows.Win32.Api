using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteFontCollection : Unknown, IDWriteFontCollection
{
    public DWriteFontCollection(nint pointer) :
        base(pointer)
    {
    }
}