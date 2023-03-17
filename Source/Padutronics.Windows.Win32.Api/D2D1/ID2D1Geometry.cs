using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd906a1-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1Geometry : ID2D1Resource
{
    void CombineWithGeometry(ID2D1Geometry inputGeometry, D2D1_COMBINE_MODE combineMode, D2D_MATRIX_3X2_F? inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);
}