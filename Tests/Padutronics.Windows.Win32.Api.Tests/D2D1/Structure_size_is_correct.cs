using NUnit.Framework;
using Padutronics.Windows.Win32.Api.D2D1;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.D2D1;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_D2D1_BITMAP_BRUSH_PROPERTIES()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_BITMAP_BRUSH_PROPERTIES)), Is.EqualTo(12));
    }

    [Test]
    public void Size_of_D2D1_BRUSH_PROPERTIES()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_BRUSH_PROPERTIES)), Is.EqualTo(28));
    }

    [Test]
    public void Size_of_D2D1_FACTORY_OPTIONS()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_FACTORY_OPTIONS)), Is.EqualTo(4));
    }

    [Test]
    public void Size_of_D2D1_GRADIENT_STOP()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_GRADIENT_STOP)), Is.EqualTo(20));
    }

    [Test]
    public void Size_of_D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES)), Is.EqualTo(16));
    }

    [Test]
    public void Size_of_D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES)), Is.EqualTo(24));
    }

    [Test]
    public void Size_of_D2D1_RENDER_TARGET_PROPERTIES()
    {
        Assert.That(Marshal.SizeOf(typeof(D2D1_RENDER_TARGET_PROPERTIES)), Is.EqualTo(28));
    }
}