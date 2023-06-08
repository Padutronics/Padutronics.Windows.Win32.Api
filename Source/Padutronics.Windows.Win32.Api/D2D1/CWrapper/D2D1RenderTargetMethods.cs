using Padutronics.Windows.Win32.Api.DCommon;
using Padutronics.Windows.Win32.Api.DxgiType;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1.CWrapper;

internal static class D2D1RenderTargetMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_BeginDraw(nint @this);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateBitmap(nint @this, D2D_SIZE_U size, nint srcData, int pitch, ref D2D1_BITMAP_PROPERTIES bitmapProperties, out nint bitmap);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateBitmapBrush(nint @this, nint bitmap, nint bitmapBrushProperties, nint brushProperties, out nint bitmapBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateBitmapFromWicBitmap(nint @this, nint wicBitmapSource, nint bitmapProperties, out nint bitmap);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateGradientStopCollection(nint @this, D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out nint gradientStopCollection);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateLayer(nint @this, nint size, out nint layer);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateLinearGradientBrush(nint @this, ref D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, nint brushProperties, nint gradientStopCollection, out nint linearGradientBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateRadialGradientBrush(nint @this, ref D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, nint brushProperties, nint gradientStopCollection, out nint radialGradientBrush);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_CreateSolidColorBrush(nint @this, ref D3DCOLORVALUE color, nint brushProperties, out nint solidColorBrush);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawBitmap(nint @this, nint bitmap, nint destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, nint sourceRectangle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawEllipse(nint @this, ref D2D1_ELLIPSE ellipse, nint brush, float strokeWidth, nint strokeStyle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawGeometry(nint @this, nint geometry, nint brush, float strokeWidth, nint strokeStyle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawLine(nint @this, D2D_POINT_2F point0, D2D_POINT_2F point1, nint brush, float strokeWidth, nint strokeStyle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawRectangle(nint @this, ref D2D_RECT_F rect, nint brush, float strokeWidth, nint strokeStyle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_DrawRoundedRectangle(nint @this, ref D2D1_ROUNDED_RECT roundedRect, nint brush, float strokeWidth, nint strokeStyle);

    [DllImport(DllNames.CWrapper, CharSet = CharSet.Unicode)]
    public static extern void ID2D1RenderTarget_DrawText(nint @this, string @string, int stringLength, nint textFormat, ref D2D_RECT_F layoutRect, nint defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);

    [DllImport(DllNames.CWrapper, PreserveSig = false)]
    public static extern void ID2D1RenderTarget_EndDraw(nint @this, out long tag1, out long tag2);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillEllipse(nint @this, ref D2D1_ELLIPSE ellipse, nint brush);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillGeometry(nint @this, nint geometry, nint brush, nint opacityBrush);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillOpacityMask(nint @this, nint opacityMask, nint brush, D2D1_OPACITY_MASK_CONTENT content, nint destinationRectangle, nint sourceRectangle);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillRectangle(nint @this, ref D2D_RECT_F rect, nint brush);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_FillRoundedRectangle(nint @this, ref D2D1_ROUNDED_RECT roundedRect, nint brush);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D1_ANTIALIAS_MODE ID2D1RenderTarget_GetAntialiasMode(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern D2D_SIZE_U ID2D1RenderTarget_GetPixelSize(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_GetTransform(nint @this, out D2D_MATRIX_3X2_F transform);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_PopAxisAlignedClip(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_PopLayer(nint @this);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_PushAxisAlignedClip(nint @this, ref D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_PushLayer(nint @this, ref D2D1_LAYER_PARAMETERS layerParameters, nint layer);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_SetAntialiasMode(nint @this, D2D1_ANTIALIAS_MODE antialiasMode);

    [DllImport(DllNames.CWrapper)]
    public static extern void ID2D1RenderTarget_SetTransform(nint @this, ref D2D_MATRIX_3X2_F transform);
}