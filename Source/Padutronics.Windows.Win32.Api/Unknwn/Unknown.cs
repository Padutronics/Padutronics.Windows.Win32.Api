using Padutronics.Interoperability;
using Padutronics.Windows.Win32.Api.Unknwn.CWrapper;
using System;

namespace Padutronics.Windows.Win32.Api.Unknwn;

public class Unknown : UnmanagedClass, IUnknown
{
    public Unknown(IntPtr pointer) :
        base(pointer)
    {
    }

    protected override void Dispose(bool isDisposing)
    {
        Release();
    }

    public int Release()
    {
        return UnknownMethods.IUnknown_Release(This);
    }
}