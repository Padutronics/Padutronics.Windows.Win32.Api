using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.DWrite.CWrapper;

internal static class DWriteTextFormatMethods
{
    [DllImport(DllNames.CWrapper)]
    public static extern float IDWriteTextFormat_GetFontSize(nint @this);
}