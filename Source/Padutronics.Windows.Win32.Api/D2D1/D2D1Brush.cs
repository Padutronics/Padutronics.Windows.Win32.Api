using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Brush : D2D1Resource, ID2D1Brush
{
    public D2D1Brush(nint pointer) :
        base(pointer)
    {
    }

    public float GetOpacity()
    {
        return D2D1BrushMethods.ID2D1Brush_GetOpacity(This);
    }

    public void GetTransform(out D2D_MATRIX_3X2_F transform)
    {
        D2D1BrushMethods.ID2D1Brush_GetTransform(This, out transform);
    }
}