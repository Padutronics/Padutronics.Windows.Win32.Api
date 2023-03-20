using Padutronics.Windows.Win32.Api.DCommon;
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
    public static extern void ID2D1RenderTarget_CreateLayer(IntPtr @this, IntPtr size, out IntPtr layer);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateLinearGradientBrush(IntPtr @this, ref D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, IntPtr brushProperties, IntPtr gradientStopCollection, out IntPtr linearGradientBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateRadialGradientBrush(IntPtr @this, ref D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, IntPtr brushProperties, IntPtr gradientStopCollection, out IntPtr radialGradientBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateSolidColorBrush(IntPtr @this, ref D3DCOLORVALUE color, IntPtr brushProperties, out IntPtr solidColorBrush);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawBitmap(IntPtr @this, IntPtr bitmap, IntPtr destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, IntPtr sourceRectangle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawEllipse(IntPtr @this, ref D2D1_ELLIPSE ellipse, IntPtr brush, float strokeWidth, IntPtr strokeStyle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawGeometry(IntPtr @this, IntPtr geometry, IntPtr brush, float strokeWidth, IntPtr strokeStyle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawLine(IntPtr @this, D2D_POINT_2F point0, D2D_POINT_2F point1, IntPtr brush, float strokeWidth, IntPtr strokeStyle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawRectangle(IntPtr @this, ref D2D_RECT_F rect, IntPtr brush, float strokeWidth, IntPtr strokeStyle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawRoundedRectangle(IntPtr @this, ref D2D1_ROUNDED_RECT roundedRect, IntPtr brush, float strokeWidth, IntPtr strokeStyle);

    [DllImport(DllNames.CWrapper, CharSet = CharSet.Unicode)]
    public static extern void ID2D1RenderTarget_DrawText(IntPtr @this, string @string, int stringLength, IntPtr textFormat, ref D2D_RECT_F layoutRect, IntPtr defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_EndDraw(IntPtr @this, out long tag1, out long tag2);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillEllipse(IntPtr @this, ref D2D1_ELLIPSE ellipse, IntPtr brush);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillGeometry(IntPtr @this, IntPtr geometry, IntPtr brush, IntPtr opacityBrush);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillOpacityMask(IntPtr @this, IntPtr opacityMask, IntPtr brush, D2D1_OPACITY_MASK_CONTENT content, IntPtr destinationRectangle, IntPtr sourceRectangle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillRectangle(IntPtr @this, ref D2D_RECT_F rect, IntPtr brush);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillRoundedRectangle(IntPtr @this, ref D2D1_ROUNDED_RECT roundedRect, IntPtr brush);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_ANTIALIAS_MODE ID2D1RenderTarget_GetAntialiasMode(IntPtr @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_GetTransform(IntPtr @this, out D2D_MATRIX_3X2_F transform);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_PopAxisAlignedClip(IntPtr @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_SetAntialiasMode(IntPtr @this, D2D1_ANTIALIAS_MODE antialiasMode);
}