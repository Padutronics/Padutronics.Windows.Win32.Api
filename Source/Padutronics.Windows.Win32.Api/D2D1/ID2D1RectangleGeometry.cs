using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906a2-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1RectangleGeometry : ID2D1Geometry
{
    void GetRect(out D2D_RECT_F rect);
}