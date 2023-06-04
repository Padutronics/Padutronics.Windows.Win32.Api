using Padutronics.Windows.Win32.Api.WTypesBase;
using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.ComBaseApi;

public static class GlobalFunctions
{
    [DllImport(DllNames.Ole32, PreserveSig = false)]
    public static extern void CoCreateInstance(ref Guid rclsid, nint pUnkOuter, CLSCTX dwClsContext, ref Guid riid, out nint ppv);
}