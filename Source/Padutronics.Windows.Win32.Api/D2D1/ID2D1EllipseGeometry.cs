using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906a4-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1EllipseGeometry : ID2D1Geometry
{
    void GetEllipse(out D2D1_ELLIPSE ellipse);
}