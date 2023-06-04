using Padutronics.Windows.Win32.Api.Unknwn;
using Padutronics.Windows.Win32.Api.WinCodec.CWrapper;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICBitmapDecoder : Unknown, IWICBitmapDecoder
{
    public WICBitmapDecoder(nint pointer) :
        base(pointer)
    {
    }

    public void GetFrame(int index, out IWICBitmapFrameDecode ppIBitmapFrame)
    {
        WICBitmapDecoderMethods.IWICBitmapDecoder_GetFrame(This, index, out nint ppIBitmapFramePointer);

        ppIBitmapFrame = new WICBitmapFrameDecode(ppIBitmapFramePointer);
    }
}