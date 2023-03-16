using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Brush : D2D1Resource, ID2D1Brush
{
    public D2D1Brush(IntPtr pointer) :
        base(pointer)
    {
    }
}