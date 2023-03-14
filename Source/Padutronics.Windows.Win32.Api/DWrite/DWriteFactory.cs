using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteFactory : Unknown, IDWriteFactory
{
    public DWriteFactory(IntPtr pointer) :
        base(pointer)
    {
    }
}