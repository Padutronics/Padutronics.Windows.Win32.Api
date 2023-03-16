using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.D2D1;

[Guid("a2296057-ea42-4099-983b-539fb6505426")]
public interface ID2D1Bitmap : ID2D1Image
{
    D2D_SIZE_U GetPixelSize();
}