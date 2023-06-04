using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Padutronics.Windows.Win32.Api.WinCodec.CWrapper;

internal static class WICImagingFactoryMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IWICImagingFactory_CreateDecoderFromStream(nint @this, IStream pIStream, nint pguidVendor, WICDecodeOptions metadataOptions, out nint ppIDecoder);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IWICImagingFactory_CreateFormatConverter(nint @this, out nint ppIFormatConverter);
}