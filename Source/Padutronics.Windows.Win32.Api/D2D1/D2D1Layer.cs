using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Layer : D2D1Resource, ID2D1Layer
{
    public D2D1Layer(IntPtr pointer) :
        base(pointer)
    {
    }
}