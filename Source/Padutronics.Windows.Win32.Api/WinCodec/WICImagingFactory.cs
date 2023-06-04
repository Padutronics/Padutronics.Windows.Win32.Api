using Padutronics.Windows.Win32.Api.Unknwn;
using Padutronics.Windows.Win32.Api.WinCodec.CWrapper;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICImagingFactory : Unknown, IWICImagingFactory
{
    public WICImagingFactory(nint pointer) :
        base(pointer)
    {
    }

    public void CreateDecoderFromStream(IStream pIStream, Guid? pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder)
    {
        Guid pguidVendorCopy;

        nint pguidVendorPointer = nint.Zero;

        if (pguidVendor.HasValue)
        {
            pguidVendorCopy = pguidVendor.Value;

            unsafe
            {
                pguidVendorPointer = new nint(&pguidVendorCopy);
            }
        }

        WICImagingFactoryMethods.IWICImagingFactory_CreateDecoderFromStream(This, pIStream, pguidVendorPointer, metadataOptions, out nint ppIDecoderPointer);

        ppIDecoder = new WICBitmapDecoder(ppIDecoderPointer);
    }

    public void CreateFormatConverter(out IWICFormatConverter ppIFormatConverter)
    {
        WICImagingFactoryMethods.IWICImagingFactory_CreateFormatConverter(This, out nint ppIFormatConverterPointer);

        ppIFormatConverter = new WICFormatConverter(ppIFormatConverterPointer);
    }
}