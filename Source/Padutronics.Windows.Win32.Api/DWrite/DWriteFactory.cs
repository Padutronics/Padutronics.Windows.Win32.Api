using Padutronics.Windows.Win32.Api.DWrite.CWrapper;
using Padutronics.Windows.Win32.Api.Unknwn;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteFactory : Unknown, IDWriteFactory
{
    public DWriteFactory(nint pointer) :
        base(pointer)
    {
    }

    public void CreateTextFormat(string fontFamilyName, IDWriteFontCollection? fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, string localeName, out IDWriteTextFormat textFormat)
    {
        DWriteFactoryMethods.IDWriteFactory_CreateTextFormat(This, fontFamilyName, fontCollection?.Pointer ?? nint.Zero, fontWeight, fontStyle, fontStretch, fontSize, localeName, out nint textFormatPointer);

        textFormat = new DWriteTextFormat(textFormatPointer);
    }

    public void CreateTextLayout(string @string, int stringLength, IDWriteTextFormat textFormat, float maxWidth, float maxHeight, out IDWriteTextLayout textLayout)
    {
        DWriteFactoryMethods.IDWriteFactory_CreateTextLayout(This, @string, stringLength, textFormat.Pointer, maxWidth, maxHeight, out nint textLayoutPointer);

        textLayout = new DWriteTextLayout(textLayoutPointer);
    }
}