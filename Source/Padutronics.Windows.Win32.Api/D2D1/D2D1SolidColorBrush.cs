using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1SolidColorBrush : D2D1Brush, ID2D1SolidColorBrush
{
    public D2D1SolidColorBrush(IntPtr pointer) :
        base(pointer)
    {
    }
}