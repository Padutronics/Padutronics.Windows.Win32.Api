using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1FactoryMethods
{
    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Factory_CreateDxgiSurfaceRenderTarget(IntPtr @this, IntPtr dxgiSurface, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out IntPtr renderTarget);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1Factory_CreateStrokeStyle(IntPtr @this, ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, float[]? dashes, int dashesCount, out IntPtr strokeStyle);
}