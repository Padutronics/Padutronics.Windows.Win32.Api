using Padutronics.Windows.Win32.Api.DWrite.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteFactory : Unknown, IDWriteFactory
{
    public DWriteFactory(IntPtr pointer) :
        base(pointer)
    {
    }

    public void CreateTextFormat(string fontFamilyName, IDWriteFontCollection? fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, string localeName, out IDWriteTextFormat textFormat)
    {
        DWriteFactoryMethods.IDWriteFactory_CreateTextFormat(This, fontFamilyName, fontCollection?.Pointer ?? IntPtr.Zero, fontWeight, fontStyle, fontStretch, fontSize, localeName, out IntPtr textFormatPointer);

        textFormat = new DWriteTextFormat(textFormatPointer);
    }
}