using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Factory : Unknown, ID2D1Factory
{
    public D2D1Factory(IntPtr pointer) :
        base(pointer)
    {
    }
}