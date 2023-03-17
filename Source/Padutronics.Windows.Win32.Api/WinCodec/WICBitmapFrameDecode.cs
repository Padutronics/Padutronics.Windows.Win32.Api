using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICBitmapFrameDecode : WICBitmapSource, IWICBitmapFrameDecode
{
    public WICBitmapFrameDecode(IntPtr pointer) :
        base(pointer)
    {
    }
}