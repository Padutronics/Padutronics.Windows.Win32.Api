using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public class WICPalette : Unknown, IWICPalette
{
    public WICPalette(IntPtr pointer) :
        base(pointer)
    {
    }
}