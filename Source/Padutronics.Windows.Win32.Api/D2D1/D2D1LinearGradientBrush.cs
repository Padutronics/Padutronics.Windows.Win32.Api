using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1LinearGradientBrush : D2D1Brush, ID2D1LinearGradientBrush
{
    public D2D1LinearGradientBrush(nint pointer) :
        base(pointer)
    {
    }

    public D2D_POINT_2F GetEndPoint()
    {
        return D2D1LinearGradientBrushMethods.ID2D1LinearGradientBrush_GetEndPoint(This);
    }

    public void GetGradientStopCollection(out ID2D1GradientStopCollection gradientStopCollection)
    {
        D2D1LinearGradientBrushMethods.ID2D1LinearGradientBrush_GetGradientStopCollection(This, out nint gradientStopCollectionPointer);

        gradientStopCollection = new D2D1GradientStopCollection(gradientStopCollectionPointer);
    }

    public D2D_POINT_2F GetStartPoint()
    {
        return D2D1LinearGradientBrushMethods.ID2D1LinearGradientBrush_GetStartPoint(This);
    }

    public void SetEndPoint(D2D_POINT_2F endPoint)
    {
        D2D1LinearGradientBrushMethods.ID2D1LinearGradientBrush_SetEndPoint(This, endPoint);
    }

    public void SetStartPoint(D2D_POINT_2F startPoint)
    {
        D2D1LinearGradientBrushMethods.ID2D1LinearGradientBrush_SetStartPoint(This, startPoint);
    }
}