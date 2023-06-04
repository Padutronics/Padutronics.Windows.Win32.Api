using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Geometry : D2D1Resource, ID2D1Geometry
{
    public D2D1Geometry(nint pointer) :
        base(pointer)
    {
    }

    public void CombineWithGeometry(ID2D1Geometry inputGeometry, D2D1_COMBINE_MODE combineMode, D2D_MATRIX_3X2_F? inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink)
    {
        D2D_MATRIX_3X2_F inputGeometryTransformCopy;

        nint inputGeometryTransformPointer = nint.Zero;

        if (inputGeometryTransform.HasValue)
        {
            inputGeometryTransformCopy = inputGeometryTransform.Value;

            unsafe
            {
                inputGeometryTransformPointer = new nint(&inputGeometryTransformCopy);
            }
        }

        D2D1GeometryMethods.ID2D1Geometry_CombineWithGeometry(This, inputGeometry.Pointer, combineMode, inputGeometryTransformPointer, flatteningTolerance, geometrySink.Pointer);
    }
}