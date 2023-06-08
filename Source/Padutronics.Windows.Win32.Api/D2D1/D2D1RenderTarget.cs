using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DCommon;
using Padutronics.Windows.Win32.Api.DWrite;
using Padutronics.Windows.Win32.Api.DxgiType;
using Padutronics.Windows.Win32.Api.WinCodec;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1RenderTarget : D2D1Resource, ID2D1RenderTarget
{
    public D2D1RenderTarget(nint pointer) :
        base(pointer)
    {
    }

    public void BeginDraw()
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_BeginDraw(This);
    }

    public void CreateBitmap(D2D_SIZE_U size, nint srcData, int pitch, ref D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateBitmap(This, size, srcData, pitch, ref bitmapProperties, out nint bitmapPointer);

        bitmap = new D2D1Bitmap(bitmapPointer);
    }

    public void CreateBitmapBrush(ID2D1Bitmap? bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        D2D1_BITMAP_BRUSH_PROPERTIES bitmapBrushPropertiesCopy;
        D2D1_BRUSH_PROPERTIES brushPropertiesCopy;

        nint bitmapBrushPropertiesPointer = nint.Zero;
        nint brushPropertiesPointer = nint.Zero;

        if (bitmapBrushProperties.HasValue)
        {
            bitmapBrushPropertiesCopy = bitmapBrushProperties.Value;

            unsafe
            {
                bitmapBrushPropertiesPointer = new nint(&bitmapBrushPropertiesCopy);
            }
        }
        if (brushProperties.HasValue)
        {
            brushPropertiesCopy = brushProperties.Value;

            unsafe
            {
                brushPropertiesPointer = new nint(&brushPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateBitmapBrush(This, bitmap?.Pointer ?? nint.Zero, bitmapBrushPropertiesPointer, brushPropertiesPointer, out nint bitmapBrushPointer);

        bitmapBrush = new D2D1BitmapBrush(bitmapBrushPointer);
    }

    public void CreateBitmapFromWicBitmap(IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        D2D1_BITMAP_PROPERTIES bitmapPropertiesCopy;

        nint bitmapPropertiesPointer = nint.Zero;

        if (bitmapProperties.HasValue)
        {
            bitmapPropertiesCopy = bitmapProperties.Value;

            unsafe
            {
                bitmapPropertiesPointer = new nint(&bitmapPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateBitmapFromWicBitmap(This, wicBitmapSource.Pointer, bitmapPropertiesPointer, out nint bitmapPointer);

        bitmap = new D2D1Bitmap(bitmapPointer);
    }

    public void CreateGradientStopCollection(D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateGradientStopCollection(This, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, out nint gradientStopCollectionPointer);

        gradientStopCollection = new D2D1GradientStopCollection(gradientStopCollectionPointer);
    }

    public void CreateLayer(D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        D2D_SIZE_F sizeCopy;

        nint sizePointer = nint.Zero;

        if (size.HasValue)
        {
            sizeCopy = size.Value;

            unsafe
            {
                sizePointer = new nint(&sizeCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateLayer(This, sizePointer, out nint layerPointer);

        layer = new D2D1Layer(layerPointer);
    }

    public void CreateLinearGradientBrush(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        D2D1_BRUSH_PROPERTIES brushPropertiesCopy;

        nint brushPropertiesPointer = nint.Zero;

        if (brushProperties.HasValue)
        {
            brushPropertiesCopy = brushProperties.Value;

            unsafe
            {
                brushPropertiesPointer = new nint(&brushPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateLinearGradientBrush(This, ref linearGradientBrushProperties, brushPropertiesPointer, gradientStopCollection.Pointer, out nint linearGradientBrushPointer);

        linearGradientBrush = new D2D1LinearGradientBrush(linearGradientBrushPointer);
    }

    public void CreateRadialGradientBrush(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        D2D1_BRUSH_PROPERTIES brushPropertiesCopy;

        nint brushPropertiesPointer = nint.Zero;

        if (brushProperties.HasValue)
        {
            brushPropertiesCopy = brushProperties.Value;

            unsafe
            {
                brushPropertiesPointer = new nint(&brushPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateRadialGradientBrush(This, ref radialGradientBrushProperties, brushPropertiesPointer, gradientStopCollection.Pointer, out nint radialGradientBrushPointer);

        radialGradientBrush = new D2D1RadialGradientBrush(radialGradientBrushPointer);
    }

    public void CreateSolidColorBrush(D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        D2D1_BRUSH_PROPERTIES brushPropertiesCopy;

        nint brushPropertiesPointer = nint.Zero;

        if (brushProperties.HasValue)
        {
            brushPropertiesCopy = brushProperties.Value;

            unsafe
            {
                brushPropertiesPointer = new nint(&brushPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateSolidColorBrush(This, ref color, brushPropertiesPointer, out nint solidColorBrushPointer);

        solidColorBrush = new D2D1SolidColorBrush(solidColorBrushPointer);
    }

    public void DrawBitmap(ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        D2D_RECT_F destinationRectangleCopy;
        D2D_RECT_F sourceRectangleCopy;

        nint destinationRectanglePointer = nint.Zero;
        nint sourceRectanglePointer = nint.Zero;

        if (destinationRectangle.HasValue)
        {
            destinationRectangleCopy = destinationRectangle.Value;

            unsafe
            {
                destinationRectanglePointer = new nint(&destinationRectangleCopy);
            }
        }
        if (sourceRectangle.HasValue)
        {
            sourceRectangleCopy = sourceRectangle.Value;

            unsafe
            {
                sourceRectanglePointer = new nint(&sourceRectangleCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_DrawBitmap(This, bitmap.Pointer, destinationRectanglePointer, opacity, interpolationMode, sourceRectanglePointer);
    }

    public void DrawEllipse(D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_DrawEllipse(This, ref ellipse, brush.Pointer, strokeWidth, strokeStyle?.Pointer ?? nint.Zero);
    }

    public void DrawGeometry(ID2D1Geometry geometry, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_DrawGeometry(This, geometry.Pointer, brush.Pointer, strokeWidth, strokeStyle?.Pointer ?? nint.Zero);
    }

    public void DrawLine(D2D_POINT_2F point0, D2D_POINT_2F point1, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_DrawLine(This, point0, point1, brush.Pointer, strokeWidth, strokeStyle?.Pointer ?? nint.Zero);
    }

    public void DrawRectangle(D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_DrawRectangle(This, ref rect, brush.Pointer, strokeWidth, strokeStyle?.Pointer ?? nint.Zero);
    }

    public void DrawRoundedRectangle(D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle? strokeStyle)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_DrawRoundedRectangle(This, ref roundedRect, brush.Pointer, strokeWidth, strokeStyle?.Pointer ?? nint.Zero);
    }

    public void DrawText(string @string, int stringLength, IDWriteTextFormat textFormat, D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_DrawText(This, @string, stringLength, textFormat.Pointer, ref layoutRect, defaultFillBrush.Pointer, options, measuringMode);
    }

    public void EndDraw(out long tag1, out long tag2)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_EndDraw(This, out tag1, out tag2);
    }

    public void FillEllipse(D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_FillEllipse(This, ref ellipse, brush.Pointer);
    }

    public void FillGeometry(ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush? opacityBrush)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_FillGeometry(This, geometry.Pointer, brush.Pointer, opacityBrush?.Pointer ?? nint.Zero);
    }

    public void FillOpacityMask(ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        D2D_RECT_F destinationRectangleCopy;
        D2D_RECT_F sourceRectangleCopy;

        nint destinationRectanglePointer = nint.Zero;
        nint sourceRectanglePointer = nint.Zero;

        if (destinationRectangle.HasValue)
        {
            destinationRectangleCopy = destinationRectangle.Value;

            unsafe
            {
                destinationRectanglePointer = new nint(&destinationRectangleCopy);
            }
        }
        if (sourceRectangle.HasValue)
        {
            sourceRectangleCopy = sourceRectangle.Value;

            unsafe
            {
                sourceRectanglePointer = new nint(&sourceRectangleCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_FillOpacityMask(This, opacityMask.Pointer, brush.Pointer, content, destinationRectanglePointer, sourceRectanglePointer);
    }

    public void FillRectangle(D2D_RECT_F rect, ID2D1Brush brush)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_FillRectangle(This, ref rect, brush.Pointer);
    }

    public void FillRoundedRectangle(D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_FillRoundedRectangle(This, ref roundedRect, brush.Pointer);
    }

    public D2D1_ANTIALIAS_MODE GetAntialiasMode()
    {
        return D2D1RenderTargetMethods.ID2D1RenderTarget_GetAntialiasMode(This);
    }

    public D2D_SIZE_U GetPixelSize()
    {
        return D2D1RenderTargetMethods.ID2D1RenderTarget_GetPixelSize(This);
    }

    public void GetTransform(out D2D_MATRIX_3X2_F transform)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_GetTransform(This, out transform);
    }

    public void PopAxisAlignedClip()
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_PopAxisAlignedClip(This);
    }

    public void PopLayer()
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_PopLayer(This);
    }

    public void PushAxisAlignedClip(D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_PushAxisAlignedClip(This, ref clipRect, antialiasMode);
    }

    public void PushLayer(D2D1_LAYER_PARAMETERS layerParameters, ID2D1Layer? layer)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_PushLayer(This, ref layerParameters, layer?.Pointer ?? nint.Zero);
    }

    public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_SetAntialiasMode(This, antialiasMode);
    }

    public void SetTransform(D2D_MATRIX_3X2_F transform)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_SetTransform(This, ref transform);
    }
}