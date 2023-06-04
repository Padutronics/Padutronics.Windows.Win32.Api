using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.DWrite;

public static class GlobalFunctions
{
    [DllImport(DllNames.DWrite, PreserveSig = false)]
    public static extern void DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, ref Guid iid, out nint factory);
}