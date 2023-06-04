using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Bitmap : D2D1Image, ID2D1Bitmap
{
    public D2D1Bitmap(nint pointer) :
        base(pointer)
    {
    }

    public D2D_SIZE_U GetPixelSize()
    {
        return D2D1BitmapMethods.ID2D1Bitmap_GetPixelSize(This);
    }

    public D2D_SIZE_F GetSize()
    {
        return D2D1BitmapMethods.ID2D1Bitmap_GetSize(This);
    }
}