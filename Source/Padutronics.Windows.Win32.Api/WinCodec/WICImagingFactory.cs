using Padutronics.Windows.Win32.Api.Unknwn;
using Padutronics.Windows.Win32.Api.WinCodec.CWrapper;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICImagingFactory : Unknown, IWICImagingFactory
{
    public WICImagingFactory(IntPtr pointer) :
        base(pointer)
    {
    }

    public void CreateDecoderFromStream(IStream pIStream, Guid? pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder)
    {
        Guid pguidVendorCopy;

        IntPtr pguidVendorPointer = IntPtr.Zero;

        if (pguidVendor.HasValue)
        {
            pguidVendorCopy = pguidVendor.Value;

            unsafe
            {
                pguidVendorPointer = new IntPtr(&pguidVendorCopy);
            }
        }

        WICImagingFactoryMethods.IWICImagingFactory_CreateDecoderFromStream(This, pIStream, pguidVendorPointer, metadataOptions, out IntPtr ppIDecoderPointer);

        ppIDecoder = new WICBitmapDecoder(ppIDecoderPointer);
    }

    public void CreateFormatConverter(out IWICFormatConverter ppIFormatConverter)
    {
        WICImagingFactoryMethods.IWICImagingFactory_CreateFormatConverter(This, out IntPtr ppIFormatConverterPointer);

        ppIFormatConverter = new WICFormatConverter(ppIFormatConverterPointer);
    }
}