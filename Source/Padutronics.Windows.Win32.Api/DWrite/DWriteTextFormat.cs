using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteTextFormat : Unknown, IDWriteTextFormat
{
    public DWriteTextFormat(IntPtr pointer) :
        base(pointer)
    {
    }
}