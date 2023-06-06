#include "IDWriteTextFormat.hpp"

auto IDWriteTextFormat_GetFontSize(IDWriteTextFormat& _this) -> FLOAT
{
    return _this.GetFontSize();
}

auto IDWriteTextFormat_GetFontStretch(IDWriteTextFormat& _this) -> DWRITE_FONT_STRETCH
{
    return _this.GetFontStretch();
}