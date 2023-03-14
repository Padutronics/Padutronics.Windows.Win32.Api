using Padutronics.Windows.Win32.Api.Unknwn;
using System;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public class DXGIObject : Unknown, IDXGIObject
{
    public DXGIObject(IntPtr pointer) :
        base(pointer)
    {
    }
}