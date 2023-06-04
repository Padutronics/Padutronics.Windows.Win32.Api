using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1RadialGradientBrush : D2D1Brush, ID2D1RadialGradientBrush
{
    public D2D1RadialGradientBrush(nint pointer) :
        base(pointer)
    {
    }
}