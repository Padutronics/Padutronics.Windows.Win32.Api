using NUnit.Framework;
using Padutronics.Windows.Win32.Api.DWrite;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.DWrite;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_DWRITE_TEXT_METRICS()
    {
        Assert.That(Marshal.SizeOf(typeof(DWRITE_TEXT_METRICS)), Is.EqualTo(36));
    }
}