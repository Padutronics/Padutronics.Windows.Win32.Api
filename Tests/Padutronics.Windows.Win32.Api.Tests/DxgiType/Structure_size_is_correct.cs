using NUnit.Framework;
using Padutronics.Windows.Win32.Api.DxgiType;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.DxgiType;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_D3DCOLORVALUE()
    {
        Assert.That(Marshal.SizeOf(typeof(D3DCOLORVALUE)), Is.EqualTo(16));
    }
}