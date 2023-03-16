using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DxgiType;
using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1RenderTarget : D2D1Resource, ID2D1RenderTarget
{
    public D2D1RenderTarget(IntPtr pointer) :
        base(pointer)
    {
    }

    public void BeginDraw()
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_BeginDraw(This);
    }

    public void CreateGradientStopCollection(D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateGradientStopCollection(This, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, out IntPtr gradientStopCollectionPointer);

        gradientStopCollection = new D2D1GradientStopCollection(gradientStopCollectionPointer);
    }

    public void CreateLinearGradientBrush(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        D2D1_BRUSH_PROPERTIES brushPropertiesCopy;

        IntPtr brushPropertiesPointer = IntPtr.Zero;

        if (brushProperties.HasValue)
        {
            brushPropertiesCopy = brushProperties.Value;

            unsafe
            {
                brushPropertiesPointer = new IntPtr(&brushPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateLinearGradientBrush(This, ref linearGradientBrushProperties, brushPropertiesPointer, gradientStopCollection.Pointer, out IntPtr linearGradientBrushPointer);

        linearGradientBrush = new D2D1LinearGradientBrush(linearGradientBrushPointer);
    }

    public void CreateRadialGradientBrush(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        D2D1_BRUSH_PROPERTIES brushPropertiesCopy;

        IntPtr brushPropertiesPointer = IntPtr.Zero;

        if (brushProperties.HasValue)
        {
            brushPropertiesCopy = brushProperties.Value;

            unsafe
            {
                brushPropertiesPointer = new IntPtr(&brushPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateRadialGradientBrush(This, ref radialGradientBrushProperties, brushPropertiesPointer, gradientStopCollection.Pointer, out IntPtr radialGradientBrushPointer);

        radialGradientBrush = new D2D1RadialGradientBrush(radialGradientBrushPointer);
    }

    public void CreateSolidColorBrush(D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        D2D1_BRUSH_PROPERTIES brushPropertiesCopy;

        IntPtr brushPropertiesPointer = IntPtr.Zero;

        if (brushProperties.HasValue)
        {
            brushPropertiesCopy = brushProperties.Value;

            unsafe
            {
                brushPropertiesPointer = new IntPtr(&brushPropertiesCopy);
            }
        }

        D2D1RenderTargetMethods.ID2D1RenderTarget_CreateSolidColorBrush(This, ref color, brushPropertiesPointer, out IntPtr solidColorBrushPointer);

        solidColorBrush = new D2D1SolidColorBrush(solidColorBrushPointer);
    }

    public void EndDraw(out long tag1, out long tag2)
    {
        D2D1RenderTargetMethods.ID2D1RenderTarget_EndDraw(This, out tag1, out tag2);
    }
}