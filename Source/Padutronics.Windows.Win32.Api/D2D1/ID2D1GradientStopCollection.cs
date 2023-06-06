using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906a7-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1GradientStopCollection : ID2D1Resource
{
    D2D1_GAMMA GetColorInterpolationGamma();
    D2D1_EXTEND_MODE GetExtendMode();
    int GetGradientStopCount();
    void GetGradientStops(D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount);
}