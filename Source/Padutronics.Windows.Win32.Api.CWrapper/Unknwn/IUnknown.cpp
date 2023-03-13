#include "IUnknown.hpp"

auto IUnknown_Release(IUnknown& _this) -> ULONG
{
    return _this.Release();
}