using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D3D11;

[StructLayout(LayoutKind.Explicit)]
public struct D3D11_BUFFER_RTV
{
    [FieldOffset(0)]
    public int FirstElement;
    [FieldOffset(4)]
    public int ElementOffset;
    [FieldOffset(0)]
    public int NumElements;
    [FieldOffset(4)]
    public int ElementWidth;
}