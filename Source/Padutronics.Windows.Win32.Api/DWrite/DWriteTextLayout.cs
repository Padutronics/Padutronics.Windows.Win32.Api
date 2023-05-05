using Padutronics.Windows.Win32.Api.DWrite.CWrapper;

namespace Padutronics.Windows.Win32.Api.DWrite;

public class DWriteTextLayout : DWriteTextFormat, IDWriteTextLayout
{
    public DWriteTextLayout(nint pointer) :
        base(pointer)
    {
    }

    public void GetMetrics(out DWRITE_TEXT_METRICS textMetrics)
    {
        DWriteTextLayoutMethods.IDWriteTextLayout_GetMetrics(This, out textMetrics);
    }
}