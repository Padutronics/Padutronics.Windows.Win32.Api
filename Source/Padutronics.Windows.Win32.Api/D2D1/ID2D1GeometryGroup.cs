using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906a6-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1GeometryGroup : ID2D1Geometry
{
    D2D1_FILL_MODE GetFillMode();
}