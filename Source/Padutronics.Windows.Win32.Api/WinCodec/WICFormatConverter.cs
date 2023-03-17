using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICFormatConverter : WICBitmapSource, IWICFormatConverter
{
    public WICFormatConverter(IntPtr pointer) :
        base(pointer)
    {
    }
}