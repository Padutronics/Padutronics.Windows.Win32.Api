using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Bitmap : D2D1Image, ID2D1Bitmap
{
    public D2D1Bitmap(IntPtr pointer) :
        base(pointer)
    {
    }
}