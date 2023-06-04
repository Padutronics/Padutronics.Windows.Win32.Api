using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICBitmapSource : Unknown, IWICBitmapSource
{
    public WICBitmapSource(nint pointer) :
        base(pointer)
    {
    }
}