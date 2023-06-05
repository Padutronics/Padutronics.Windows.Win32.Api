using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906a8-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1Brush : ID2D1Resource
{
    float GetOpacity();
    void GetTransform(out D2D_MATRIX_3X2_F transform);
    void SetOpacity(float opacity);
}