using NUnit.Framework;
using Padutronics.Windows.Win32.Api.Dxgi;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.Dxgi;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_DXGI_MODE_DESC()
    {
        Assert.That(Marshal.SizeOf(typeof(DXGI_MODE_DESC)), Is.EqualTo(28));
    }
}