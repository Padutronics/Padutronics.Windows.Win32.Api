using Padutronics.Windows.Win32.Api.D2D1.CWrapper;
using Padutronics.Windows.Win32.Api.DxgiType;
using System;

namespace Padutronics.Windows.Win32.Api.D2D1;

public class D2D1SolidColorBrush : D2D1Brush, ID2D1SolidColorBrush
{
    public D2D1SolidColorBrush(IntPtr pointer) :
        base(pointer)
    {
    }

    public D3DCOLORVALUE GetColor()
    {
        return D2D1SolidColorBrushMethods.ID2D1SolidColorBrush_GetColor(This);
    }

    public void SetColor(D3DCOLORVALUE color)
    {
        D2D1SolidColorBrushMethods.ID2D1SolidColorBrush_SetColor(This, ref color);
    }
}