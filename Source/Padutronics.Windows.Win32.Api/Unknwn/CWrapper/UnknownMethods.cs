using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Unknwn.CWrapper;

internal static class UnknownMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern int IUnknown_Release(IntPtr @this);
}