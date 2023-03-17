using Padutronics.Windows.Win32.Api.Unknwn;
using Padutronics.Windows.Win32.Api.WinCodec.CWrapper;
using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICBitmapDecoder : Unknown, IWICBitmapDecoder
{
    public WICBitmapDecoder(IntPtr pointer) :
        base(pointer)
    {
    }

    public void GetFrame(int index, out IWICBitmapFrameDecode ppIBitmapFrame)
    {
        WICBitmapDecoderMethods.IWICBitmapDecoder_GetFrame(This, index, out IntPtr ppIBitmapFramePointer);

        ppIBitmapFrame = new WICBitmapFrameDecode(ppIBitmapFramePointer);
    }
}