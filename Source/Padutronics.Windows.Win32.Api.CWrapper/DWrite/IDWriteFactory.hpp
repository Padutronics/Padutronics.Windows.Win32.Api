#pragma once

#include "..\Configuration.hpp"

#include <dwrite.h>

EXPORT auto IDWriteFactory_CreateTextFormat(IDWriteFactory& _this, WCHAR const* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, FLOAT fontSize, WCHAR const* localeName, IDWriteTextFormat** textFormat) -> HRESULT;