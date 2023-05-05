#pragma once

#include "..\Configuration.hpp"

#include <dwrite.h>

EXPORT auto IDWriteTextLayout_GetMetrics(IDWriteTextLayout& _this, DWRITE_TEXT_METRICS* textMetrics) -> HRESULT;