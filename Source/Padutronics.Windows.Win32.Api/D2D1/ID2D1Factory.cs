using Padutronics.Windows.Win32.Api.Dxgi;
using Padutronics.Windows.Win32.Api.Unknwn;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("06152247-6f50-465a-9245-118bfd3b6007")]
public interface ID2D1Factory : IUnknown
{
    void CreateDxgiSurfaceRenderTarget(IDXGISurface dxgiSurface, D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1RenderTarget renderTarget);
    void CreateStrokeStyle(D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, float[]? dashes, int dashesCount, out ID2D1StrokeStyle strokeStyle);
}