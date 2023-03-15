using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Resource : Unknown, ID2D1Resource
{
    public D2D1Resource(IntPtr pointer) :
        base(pointer)
    {
    }
}