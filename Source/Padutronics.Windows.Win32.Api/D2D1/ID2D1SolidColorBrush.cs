using Padutronics.Windows.Win32.Api.DxgiType;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906a9-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1SolidColorBrush : ID2D1Brush
{
    D3DCOLORVALUE GetColor();
}