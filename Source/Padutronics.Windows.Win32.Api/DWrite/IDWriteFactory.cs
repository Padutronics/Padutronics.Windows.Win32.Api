using Padutronics.Windows.Win32.Api.Unknwn;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.DWrite;

[Guid("b859ee5a-d838-4b5b-a2e8-1adc7d93db48")]
public interface IDWriteFactory : IUnknown
{
    void CreateTextFormat(string fontFamilyName, IDWriteFontCollection? fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, string localeName, out IDWriteTextFormat textFormat);
}