using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1GradientStopCollection : D2D1Resource, ID2D1GradientStopCollection
{
    public D2D1GradientStopCollection(IntPtr pointer) :
        base(pointer)
    {
    }
}