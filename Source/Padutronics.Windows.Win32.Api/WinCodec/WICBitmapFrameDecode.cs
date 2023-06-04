namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICBitmapFrameDecode : WICBitmapSource, IWICBitmapFrameDecode
{
    public WICBitmapFrameDecode(nint pointer) :
        base(pointer)
    {
    }
}