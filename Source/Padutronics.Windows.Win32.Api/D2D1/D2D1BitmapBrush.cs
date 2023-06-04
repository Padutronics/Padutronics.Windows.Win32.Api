namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1BitmapBrush : D2D1Brush, ID2D1BitmapBrush
{
    public D2D1BitmapBrush(nint pointer) :
        base(pointer)
    {
    }
}