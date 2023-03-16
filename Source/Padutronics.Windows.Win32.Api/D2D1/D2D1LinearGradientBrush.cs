using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1LinearGradientBrush : D2D1Brush, ID2D1LinearGradientBrush
{
    public D2D1LinearGradientBrush(IntPtr pointer) :
        base(pointer)
    {
    }
}