using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICPalette : Unknown, IWICPalette
{
    public WICPalette(nint pointer) :
        base(pointer)
    {
    }
}