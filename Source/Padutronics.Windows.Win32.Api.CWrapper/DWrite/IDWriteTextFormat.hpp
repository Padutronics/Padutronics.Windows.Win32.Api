#pragma once

#include "../Configuration.hpp"

#include <dwrite.h>

EXPORT auto IDWriteTextFormat_GetFontFamilyName(IDWriteTextFormat& _this, WCHAR* fontFamilyName, UINT32 nameSize) -> HRESULT;
EXPORT auto IDWriteTextFormat_GetFontFamilyNameLength(IDWriteTextFormat& _this) -> UINT32;
EXPORT auto IDWriteTextFormat_GetFontSize(IDWriteTextFormat& _this) -> FLOAT;
EXPORT auto IDWriteTextFormat_GetFontStretch(IDWriteTextFormat& _this) -> DWRITE_FONT_STRETCH;
EXPORT auto IDWriteTextFormat_GetFontStyle(IDWriteTextFormat& _this) -> DWRITE_FONT_STYLE;
EXPORT auto IDWriteTextFormat_GetFontWeight(IDWriteTextFormat& _this) -> DWRITE_FONT_WEIGHT;