using NUnit.Framework;
using Padutronics.Windows.Win32.Api.WinUser;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.WinUser;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_MSG()
    {
        Assert.That(Marshal.SizeOf(typeof(MSG)), Is.EqualTo(48));
    }

    [Test]
    public void Size_of_WNDCLASSEXW()
    {
        Assert.That(Marshal.SizeOf(typeof(WNDCLASSEXW)), Is.EqualTo(80));
    }
}