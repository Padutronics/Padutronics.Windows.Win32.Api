using NUnit.Framework;
using Padutronics.Windows.Win32.Api.DCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.DCommon;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_D2D_SIZE_U()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D_SIZE_U)), Is.EqualTo(8));
    }

    [Test]
    public void Size_of_D2D1_PIXEL_FORMAT()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_PIXEL_FORMAT)), Is.EqualTo(8));
    }
}