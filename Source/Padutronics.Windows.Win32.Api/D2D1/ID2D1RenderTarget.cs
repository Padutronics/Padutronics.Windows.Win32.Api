using Padutronics.Windows.Win32.Api.DCommon;
using Padutronics.Windows.Win32.Api.DWrite;
using Padutronics.Windows.Win32.Api.DxgiType;
using Padutronics.Windows.Win32.Api.WinCodec;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd90694-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1RenderTarget : ID2D1Resource
{
    void BeginDraw();
    void CreateBitmapBrush(ID2D1Bitmap? bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush);
    void CreateBitmapFromWicBitmap(IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap);
    void CreateGradientStopCollection(D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection);
    void CreateLayer(D2D_SIZE_F? size, out ID2D1Layer layer);
    void CreateLinearGradientBrush(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush);
    void CreateRadialGradientBrush(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush);
    void CreateSolidColorBrush(D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush);
    void DrawBitmap(ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle);
    void DrawEllipse(D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle);
    void DrawGeometry(ID2D1Geometry geometry, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle);
    void DrawLine(D2D_POINT_2F point0, D2D_POINT_2F point1, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle);
    void DrawRectangle(D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle);
    void DrawRoundedRectangle(D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle);
    void DrawText(string @string, int stringLength, IDWriteTextFormat textFormat, D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
    void EndDraw(out long tag1, out long tag2);
    void FillEllipse(D2D1_ELLIPSE ellipse, ID2D1Brush brush);
    void FillGeometry(ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush? opacityBrush);
    void FillOpacityMask(ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle);
    void FillRectangle(D2D_RECT_F rect, ID2D1Brush brush);
    void FillRoundedRectangle(D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush);
    D2D1_ANTIALIAS_MODE GetAntialiasMode();
    void GetTransform(out D2D_MATRIX_3X2_F transform);
    void PopAxisAlignedClip();
    void PopLayer();
    void PushAxisAlignedClip(D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
    void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);
}