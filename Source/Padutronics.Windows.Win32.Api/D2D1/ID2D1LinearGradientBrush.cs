using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906ab-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1LinearGradientBrush : ID2D1Brush
{
    D2D_POINT_2F GetEndPoint();
    D2D_POINT_2F GetStartPoint();
    void SetEndPoint(D2D_POINT_2F endPoint);
}