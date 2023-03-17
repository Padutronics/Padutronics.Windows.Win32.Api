#include "IWICImagingFactory.hpp"

auto IWICImagingFactory_CreateDecoderFromStream(IWICImagingFactory& _this, IStream* pIStream, const GUID* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder) -> HRESULT
{
    return _this.CreateDecoderFromStream(pIStream, pguidVendor, metadataOptions, ppIDecoder);
}

auto IWICImagingFactory_CreateFormatConverter(IWICImagingFactory& _this, IWICFormatConverter** ppIFormatConverter) -> HRESULT
{
    return _this.CreateFormatConverter(ppIFormatConverter);
}