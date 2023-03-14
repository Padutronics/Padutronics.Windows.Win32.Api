using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICImagingFactory : Unknown, IWICImagingFactory
{
    public WICImagingFactory(IntPtr pointer) :
        base(pointer)
    {
    }
}