#include "IDWriteTextLayout.hpp"

auto IDWriteTextLayout_GetMetrics(IDWriteTextLayout& _this, DWRITE_TEXT_METRICS* textMetrics) -> HRESULT
{
    return _this.GetMetrics(textMetrics);
}