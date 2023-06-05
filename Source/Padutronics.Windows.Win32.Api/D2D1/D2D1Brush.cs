using Padutronics.Windows.Win32.Api.D2D1.CWrapper;

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
}