using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Resource : Unknown, ID2D1Resource
{
    public D2D1Resource(nint pointer) :
        base(pointer)
    {
    }
}