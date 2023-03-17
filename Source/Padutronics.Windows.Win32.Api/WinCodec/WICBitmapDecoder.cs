using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICBitmapDecoder : Unknown, IWICBitmapDecoder
{
    public WICBitmapDecoder(IntPtr pointer) :
        base(pointer)
    {
    }
}