#include "ID3D11Device.hpp"

void ID3D11Device_GetImmediateContext(ID3D11Device& _this, ID3D11DeviceContext** ppImmediateContext)
{
    _this.GetImmediateContext(ppImmediateContext);
}