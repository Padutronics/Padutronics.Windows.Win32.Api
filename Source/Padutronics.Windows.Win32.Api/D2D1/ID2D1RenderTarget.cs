using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd90694-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1RenderTarget : ID2D1Resource
{
    void BeginDraw();
    void EndDraw(out long tag1, out long tag2);
}