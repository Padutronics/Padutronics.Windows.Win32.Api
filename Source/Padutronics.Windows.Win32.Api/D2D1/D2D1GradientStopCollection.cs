using Padutronics.Windows.Win32.Api.D2D1.CWrapper;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1GradientStopCollection : D2D1Resource, ID2D1GradientStopCollection
{
    public D2D1GradientStopCollection(nint pointer) :
        base(pointer)
    {
    }

    public D2D1_EXTEND_MODE GetExtendMode()
    {
        return D2D1GradientStopCollectionMethods.ID2D1GradientStopCollection_GetExtendMode(This);
    }

    public int GetGradientStopCount()
    {
        return D2D1GradientStopCollectionMethods.ID2D1GradientStopCollection_GetGradientStopCount(This);
    }

    public void GetGradientStops(D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount)
    {
        D2D1GradientStopCollectionMethods.ID2D1GradientStopCollection_GetGradientStops(This, gradientStops, gradientStopsCount);
    }
}