using Padutronics.Windows.Win32.Api.DxgiType;
using System;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1RenderTargetMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_BeginDraw(IntPtr @this);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateBitmapBrush(IntPtr @this, IntPtr bitmap, IntPtr bitmapBrushProperties, IntPtr brushProperties, out IntPtr bitmapBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateBitmapFromWicBitmap(IntPtr @this, IntPtr wicBitmapSource, IntPtr bitmapProperties, out IntPtr bitmap);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateGradientStopCollection(IntPtr @this, D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out IntPtr gradientStopCollection);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateLinearGradientBrush(IntPtr @this, ref D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, IntPtr brushProperties, IntPtr gradientStopCollection, out IntPtr linearGradientBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateRadialGradientBrush(IntPtr @this, ref D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, IntPtr brushProperties, IntPtr gradientStopCollection, out IntPtr radialGradientBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateSolidColorBrush(IntPtr @this, ref D3DCOLORVALUE color, IntPtr brushProperties, out IntPtr solidColorBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_EndDraw(IntPtr @this, out long tag1, out long tag2);
}