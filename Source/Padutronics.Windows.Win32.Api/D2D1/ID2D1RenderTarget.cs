using Padutronics.Windows.Win32.Api.DxgiType;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd90694-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1RenderTarget : ID2D1Resource
{
    void BeginDraw();
    void CreateLinearGradientBrush(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush);
    void CreateSolidColorBrush(D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush);
    void EndDraw(out long tag1, out long tag2);
}