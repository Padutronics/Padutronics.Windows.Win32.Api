using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1SimplifiedGeometrySink : Unknown, ID2D1SimplifiedGeometrySink
{
    public D2D1SimplifiedGeometrySink(IntPtr pointer) :
        base(pointer)
    {
    }

    public void Close()
    {
        D2D1SimplifiedGeometrySinkMethods.ID2D1SimplifiedGeometrySink_Close(This);
    }
}