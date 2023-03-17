using Padutronics.Windows.Win32.Api.Unknwn;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Padutronics.Windows.Win32.Api.WinCodec;

[Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70")]
public interface IWICImagingFactory : IUnknown
{
    void CreateDecoderFromStream(IStream pIStream, Guid? pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);
    void CreateFormatConverter(out IWICFormatConverter ppIFormatConverter);
}