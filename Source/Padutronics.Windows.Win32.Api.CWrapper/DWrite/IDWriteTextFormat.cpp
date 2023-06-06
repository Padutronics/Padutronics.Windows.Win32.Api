#include "IDWriteTextFormat.hpp"

auto IDWriteTextFormat_GetFontSize(IDWriteTextFormat& _this) -> FLOAT
{
    return _this.GetFontSize();
}

auto IDWriteTextFormat_GetFontStretch(IDWriteTextFormat& _this) -> DWRITE_FONT_STRETCH
{
    return _this.GetFontStretch();
}

auto IDWriteTextFormat_GetFontStyle(IDWriteTextFormat& _this) -> DWRITE_FONT_STYLE
{
    return _this.GetFontStyle();
}

auto IDWriteTextFormat_GetFontWeight(IDWriteTextFormat& _this) -> DWRITE_FONT_WEIGHT
{
    return _this.GetFontWeight();
}