using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.WinCodec.CWrapper;

internal static class WICBitmapDecoderMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void IWICBitmapDecoder_GetFrame(IntPtr @this, int index, out IntPtr ppIBitmapFrame);
}