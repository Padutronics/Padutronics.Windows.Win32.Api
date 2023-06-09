using Padutronics.Windows.Win32.Api.Unknwn;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("2cd90691-12e2-11dc-9fed-001143a055f9")]
public interface ID2D1Resource : IUnknown
{
    void GetFactory(out ID2D1Factory factory);
}