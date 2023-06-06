#include "IDWriteTextFormat.hpp"

auto IDWriteTextFormat_GetFontSize(IDWriteTextFormat& _this) -> FLOAT
{
    return _this.GetFontSize();
}