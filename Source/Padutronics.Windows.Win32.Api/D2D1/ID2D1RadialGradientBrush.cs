using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906ac-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1RadialGradientBrush : ID2D1Brush
{
    D2D_POINT_2F GetCenter();
    D2D_POINT_2F GetGradientOriginOffset();
    void GetGradientStopCollection(out ID2D1GradientStopCollection gradientStopCollection);
    float GetRadiusX();
    float GetRadiusY();
    void SetCenter(D2D_POINT_2F center);
    void SetGradientOriginOffset(D2D_POINT_2F gradientOriginOffset);
    void SetRadiusX(float radiusX);
    void SetRadiusY(float radiusY);
}