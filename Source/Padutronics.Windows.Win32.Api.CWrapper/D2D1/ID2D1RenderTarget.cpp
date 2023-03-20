#include "ID2D1RenderTarget.hpp"

void ID2D1RenderTarget_BeginDraw(ID2D1RenderTarget& _this)
{
    _this.BeginDraw();
}

auto ID2D1RenderTarget_CreateBitmapBrush(ID2D1RenderTarget& _this, ID2D1Bitmap* bitmap, const D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush) -> HRESULT
{
    return _this.CreateBitmapBrush(bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
}

auto ID2D1RenderTarget_CreateBitmapFromWicBitmap(ID2D1RenderTarget& _this, IWICBitmapSource* wicBitmapSource, const D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap) -> HRESULT
{
    return _this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties, bitmap);
}

auto ID2D1RenderTarget_CreateGradientStopCollection(ID2D1RenderTarget& _this, const D2D1_GRADIENT_STOP* gradientStops, UINT32 gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection) -> HRESULT
{
    return _this.CreateGradientStopCollection(gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
}

auto ID2D1RenderTarget_CreateLayer(ID2D1RenderTarget& _this, const D2D1_SIZE_F* size, ID2D1Layer** layer) -> HRESULT
{
    return _this.CreateLayer(size, layer);
}

auto ID2D1RenderTarget_CreateLinearGradientBrush(ID2D1RenderTarget& _this, const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush) -> HRESULT
{
    return _this.CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
}

auto ID2D1RenderTarget_CreateRadialGradientBrush(ID2D1RenderTarget& _this, const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush) -> HRESULT
{
    return _this.CreateRadialGradientBrush(radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
}

auto ID2D1RenderTarget_CreateSolidColorBrush(ID2D1RenderTarget& _this, const D2D1_COLOR_F* color, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush) -> HRESULT
{
    return _this.CreateSolidColorBrush(color, brushProperties, solidColorBrush);
}

void ID2D1RenderTarget_DrawEllipse(ID2D1RenderTarget& _this, const D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)
{
    _this.DrawEllipse(ellipse, brush, strokeWidth, strokeStyle);
}

void ID2D1RenderTarget_DrawGeometry(ID2D1RenderTarget& _this, ID2D1Geometry* geometry, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)
{
    _this.DrawGeometry(geometry, brush, strokeWidth, strokeStyle);
}

void ID2D1RenderTarget_DrawLine(ID2D1RenderTarget& _this, D2D1_POINT_2F point0, D2D1_POINT_2F point1, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)
{
    _this.DrawLine(point0, point1, brush, strokeWidth, strokeStyle);
}

void ID2D1RenderTarget_DrawRectangle(ID2D1RenderTarget& _this, const D2D1_RECT_F* rect, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)
{
    _this.DrawRectangle(rect, brush, strokeWidth, strokeStyle);
}

void ID2D1RenderTarget_DrawRoundedRectangle(ID2D1RenderTarget& _this, const D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle)
{
    _this.DrawRoundedRectangle(roundedRect, brush, strokeWidth, strokeStyle);
}

auto ID2D1RenderTarget_EndDraw(ID2D1RenderTarget& _this, D2D1_TAG* tag1, D2D1_TAG* tag2) -> HRESULT
{
    return _this.EndDraw(tag1, tag2);
}