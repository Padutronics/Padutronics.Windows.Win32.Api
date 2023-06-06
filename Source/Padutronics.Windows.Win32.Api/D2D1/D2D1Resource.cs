using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Resource : Unknown, ID2D1Resource
{
    public D2D1Resource(nint pointer) :
        base(pointer)
    {
    }

    public void GetFactory(out ID2D1Factory factory)
    {
        D2D1ResourceMethods.ID2D1Resource_GetFactory(This, out nint factoryPointer);

        factory = new D2D1Factory(factoryPointer);
    }
}