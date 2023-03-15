#pragma once

#include "..\Configuration.hpp"

#include <d3d11.h>

EXPORT void ID3D11Device_GetImmediateContext(ID3D11Device& _this, ID3D11DeviceContext** ppImmediateContext);