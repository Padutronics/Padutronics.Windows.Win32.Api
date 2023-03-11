using NUnit.Framework;
using Padutronics.Windows.Win32.Api.WinDef;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.WinDef;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_RECT()
    {
        Assert.That(Marshal.SizeOf(typeof(RECT)), Is.EqualTo(16));
    }
}