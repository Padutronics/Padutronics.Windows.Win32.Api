using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906aa-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1BitmapBrush : ID2D1Brush
{
    void GetBitmap(out ID2D1Bitmap bitmap);
    D2D1_EXTEND_MODE GetExtendModeX();
    D2D1_EXTEND_MODE GetExtendModeY();
    D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode();
    void SetBitmap(ID2D1Bitmap bitmap);
    void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);
    void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);
}