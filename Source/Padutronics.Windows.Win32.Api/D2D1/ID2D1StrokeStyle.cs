using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd9069d-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1StrokeStyle : ID2D1Resource
{
    D2D1_CAP_STYLE GetDashCap();
    float GetDashOffset();
    D2D1_DASH_STYLE GetDashStyle();
    D2D1_CAP_STYLE GetEndCap();
    D2D1_CAP_STYLE GetStartCap();
}