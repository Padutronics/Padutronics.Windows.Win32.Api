using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICBitmapSource : Unknown, IWICBitmapSource
{
    public WICBitmapSource(IntPtr pointer) :
        base(pointer)
    {
    }
}