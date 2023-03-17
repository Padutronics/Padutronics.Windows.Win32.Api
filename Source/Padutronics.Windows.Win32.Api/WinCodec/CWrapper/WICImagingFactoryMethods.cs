using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Padutronics.Windows.Win32.Api.WinCodec.CWrapper;

internal static class WICImagingFactoryMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IWICImagingFactory_CreateDecoderFromStream(IntPtr @this, IStream pIStream, IntPtr pguidVendor, WICDecodeOptions metadataOptions, out IntPtr ppIDecoder);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IWICImagingFactory_CreateFormatConverter(IntPtr @this, out IntPtr ppIFormatConverter);
}