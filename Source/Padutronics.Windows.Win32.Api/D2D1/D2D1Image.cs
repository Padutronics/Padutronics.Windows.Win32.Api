namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1Image : D2D1Resource, ID2D1Image
{
    public D2D1Image(nint pointer) :
        base(pointer)
    {
    }
}