using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.DCommon;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct D2D_MATRIX_3X2_F
{
    [FieldOffset(0)]
    public float m11;
    [FieldOffset(4)]
    public float m12;
    [FieldOffset(8)]
    public float m21;
    [FieldOffset(12)]
    public float m22;
    [FieldOffset(16)]
    public float dx;
    [FieldOffset(20)]
    public float dy;

    [FieldOffset(0)]
    public float _11;
    [FieldOffset(4)]
    public float _12;
    [FieldOffset(8)]
    public float _21;
    [FieldOffset(12)]
    public float _22;
    [FieldOffset(16)]
    public float _31;
    [FieldOffset(20)]
    public float _32;

    [FieldOffset(0)]
    public fixed float m[6];
}