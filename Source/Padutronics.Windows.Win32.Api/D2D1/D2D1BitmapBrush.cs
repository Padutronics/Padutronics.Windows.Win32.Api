using Padutronics.Windows.Win32.Api.D2D1.CWrapper;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1BitmapBrush : D2D1Brush, ID2D1BitmapBrush
{
    public D2D1BitmapBrush(nint pointer) :
        base(pointer)
    {
    }

    public void GetBitmap(out ID2D1Bitmap bitmap)
    {
        D2D1BitmapBrushMethods.ID2D1BitmapBrush_GetBitmap(This, out nint bitmapPointer);

        bitmap = new D2D1Bitmap(bitmapPointer);
    }

    public D2D1_EXTEND_MODE GetExtendModeX()
    {
        return D2D1BitmapBrushMethods.ID2D1BitmapBrush_GetExtendModeX(This);
    }
}