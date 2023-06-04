using Padutronics.Windows.Win32.Api.D3DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D3D11;

public static class GlobalFunctions
{
    [DllImport(DllNames.D3D11, PreserveSig = false)]
    public static extern void D3D11CreateDevice(nint pAdapter, D3D_DRIVER_TYPE DriverType, nint Software, D3D11_CREATE_DEVICE_FLAG Flags, D3D_FEATURE_LEVEL[] pFeatureLevels, int FeatureLevels, int SDKVersion, out nint ppDevice, out D3D_FEATURE_LEVEL pFeatureLevel, out nint ppImmediateContext);
}