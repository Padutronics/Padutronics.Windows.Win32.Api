using NUnit.Framework;
using Padutronics.Windows.Win32.Api.DxgiCommon;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.DxgiCommon;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_DXGI_RATIONAL()
    {
        Assert.That(Marshal.SizeOf(typeof(DXGI_RATIONAL)), Is.EqualTo(8));
    }

    [Test]
    public void Size_of_DXGI_SAMPLE_DESC()
    {
        Assert.That(Marshal.SizeOf(typeof(DXGI_SAMPLE_DESC)), Is.EqualTo(8));
    }
}