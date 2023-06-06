#pragma once

#include "../Configuration.hpp"

#include <dwrite.h>

EXPORT auto IDWriteTextFormat_GetFontSize(IDWriteTextFormat& _this) -> FLOAT;