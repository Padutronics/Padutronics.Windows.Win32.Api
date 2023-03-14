using NUnit.Framework;
using Padutronics.Windows.Win32.Api.D2D1;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.D2D1;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_D2D1_FACTORY_OPTIONS()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_FACTORY_OPTIONS)), Is.EqualTo(4));
    }
}