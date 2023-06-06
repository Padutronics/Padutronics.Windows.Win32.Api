#include "ID2D1Resource.hpp"

void ID2D1Resource_GetFactory(ID2D1Resource& _this, ID2D1Factory** factory)
{
    _this.GetFactory(factory);
}