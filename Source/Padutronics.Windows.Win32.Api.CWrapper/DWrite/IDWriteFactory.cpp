#include "IDWriteFactory.hpp"

auto IDWriteFactory_CreateTextFormat(IDWriteFactory& _this, WCHAR const* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, FLOAT fontSize, WCHAR const* localeName, IDWriteTextFormat** textFormat) -> HRESULT
{
    return _this.CreateTextFormat(fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
}

auto IDWriteFactory_CreateTextLayout(IDWriteFactory& _this, WCHAR const* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT maxWidth, FLOAT maxHeight, IDWriteTextLayout** textLayout) -> HRESULT
{
    return _this.CreateTextLayout(string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
}