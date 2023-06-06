using Padutronics.Windows.Win32.Api.Unknwn;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.DWrite;

[Guid("9c906818-31d7-4fd3-a151-7c5e225db55a")]
public interface IDWriteTextFormat : IUnknown
{
    int GetFontFamilyNameLength();
    float GetFontSize();
    DWRITE_FONT_STRETCH GetFontStretch();
    DWRITE_FONT_STYLE GetFontStyle();
    DWRITE_FONT_WEIGHT GetFontWeight();
}