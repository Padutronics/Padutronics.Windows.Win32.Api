#include "ID2D1RenderTarget.hpp"

void ID2D1RenderTarget_BeginDraw(ID2D1RenderTarget& _this)
{
    _this.BeginDraw();
}

auto ID2D1RenderTarget_EndDraw(ID2D1RenderTarget& _this, D2D1_TAG* tag1, D2D1_TAG* tag2) -> HRESULT
{
    return _this.EndDraw(tag1, tag2);
}