using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteFontCollection : Unknown, IDWriteFontCollection
{
    public DWriteFontCollection(IntPtr pointer) :
        base(pointer)
    {
    }
}