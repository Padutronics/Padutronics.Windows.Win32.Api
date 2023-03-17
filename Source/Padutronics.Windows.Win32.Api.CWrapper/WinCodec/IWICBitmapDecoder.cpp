#include "IWICBitmapDecoder.hpp"

auto IWICBitmapDecoder_GetFrame(IWICBitmapDecoder& _this, UINT index, IWICBitmapFrameDecode** ppIBitmapFrame) -> HRESULT
{
    return _this.GetFrame(index, ppIBitmapFrame);
}