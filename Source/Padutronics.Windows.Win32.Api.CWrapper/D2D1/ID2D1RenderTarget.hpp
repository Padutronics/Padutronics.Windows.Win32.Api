#pragma once

#include "..\Configuration.hpp"

#include <d2d1.h>

EXPORT void ID2D1RenderTarget_BeginDraw(ID2D1RenderTarget& _this);
EXPORT auto ID2D1RenderTarget_CreateBitmapBrush(ID2D1RenderTarget& _this, ID2D1Bitmap* bitmap, const D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateBitmapFromWicBitmap(ID2D1RenderTarget& _this, IWICBitmapSource* wicBitmapSource, const D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateGradientStopCollection(ID2D1RenderTarget& _this, const D2D1_GRADIENT_STOP* gradientStops, UINT32 gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateLayer(ID2D1RenderTarget& _this, const D2D1_SIZE_F* size, ID2D1Layer** layer) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateLinearGradientBrush(ID2D1RenderTarget& _this, const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateRadialGradientBrush(ID2D1RenderTarget& _this, const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush) -> HRESULT;
EXPORT auto ID2D1RenderTarget_CreateSolidColorBrush(ID2D1RenderTarget& _this, const D2D1_COLOR_F* color, const D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush) -> HRESULT;
EXPORT void ID2D1RenderTarget_DrawBitmap(ID2D1RenderTarget& _this, ID2D1Bitmap* bitmap, const D2D1_RECT_F* destinationRectangle, FLOAT opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, const D2D1_RECT_F* sourceRectangle);
EXPORT void ID2D1RenderTarget_DrawEllipse(ID2D1RenderTarget& _this, const D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle);
EXPORT void ID2D1RenderTarget_DrawGeometry(ID2D1RenderTarget& _this, ID2D1Geometry* geometry, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle);
EXPORT void ID2D1RenderTarget_DrawLine(ID2D1RenderTarget& _this, D2D1_POINT_2F point0, D2D1_POINT_2F point1, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle);
EXPORT void ID2D1RenderTarget_DrawRectangle(ID2D1RenderTarget& _this, const D2D1_RECT_F* rect, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle);
EXPORT void ID2D1RenderTarget_DrawRoundedRectangle(ID2D1RenderTarget& _this, const D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, FLOAT strokeWidth, ID2D1StrokeStyle* strokeStyle);
EXPORT void ID2D1RenderTarget_DrawText(ID2D1RenderTarget& _this, const WCHAR* string, UINT32 stringLength, IDWriteTextFormat* textFormat, const D2D1_RECT_F* layoutRect, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
EXPORT auto ID2D1RenderTarget_EndDraw(ID2D1RenderTarget& _this, D2D1_TAG* tag1, D2D1_TAG* tag2) -> HRESULT;
EXPORT void ID2D1RenderTarget_FillEllipse(ID2D1RenderTarget& _this, const D2D1_ELLIPSE* ellipse, ID2D1Brush* brush);
EXPORT void ID2D1RenderTarget_FillGeometry(ID2D1RenderTarget& _this, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush);
EXPORT void ID2D1RenderTarget_FillOpacityMask(ID2D1RenderTarget& _this, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, const D2D1_RECT_F* destinationRectangle, const D2D1_RECT_F* sourceRectangle);
EXPORT void ID2D1RenderTarget_FillRectangle(ID2D1RenderTarget& _this, const D2D1_RECT_F* rect, ID2D1Brush* brush);
EXPORT void ID2D1RenderTarget_FillRoundedRectangle(ID2D1RenderTarget& _this, const D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush);
EXPORT auto ID2D1RenderTarget_GetAntialiasMode(ID2D1RenderTarget& _this) -> D2D1_ANTIALIAS_MODE;
EXPORT void ID2D1RenderTarget_GetTransform(ID2D1RenderTarget& _this, D2D1_MATRIX_3X2_F* transform);
EXPORT void ID2D1RenderTarget_PopAxisAlignedClip(ID2D1RenderTarget& _this);
EXPORT void ID2D1RenderTarget_PopLayer(ID2D1RenderTarget& _this);
EXPORT void ID2D1RenderTarget_PushAxisAlignedClip(ID2D1RenderTarget& _this, const D2D1_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
EXPORT void ID2D1RenderTarget_SetAntialiasMode(ID2D1RenderTarget& _this, D2D1_ANTIALIAS_MODE antialiasMode);