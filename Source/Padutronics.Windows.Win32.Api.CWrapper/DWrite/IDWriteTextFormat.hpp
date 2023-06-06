#pragma once

#include "../Configuration.hpp"

#include <dwrite.h>

EXPORT auto IDWriteTextFormat_GetFontSize(IDWriteTextFormat& _this) -> FLOAT;
EXPORT auto IDWriteTextFormat_GetFontStretch(IDWriteTextFormat& _this) -> DWRITE_FONT_STRETCH;