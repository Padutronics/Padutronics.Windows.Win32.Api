using NUnit.Framework;
using Padutronics.Windows.Win32.Api.D3D11;
using System.Runtime.InteropServices;

namespace Padutronics.Windows.Win32.Api.Tests.D3D11;

[TestFixture]
internal sealed class Structure_size_is_correct
{
    [Test]
    public void Size_of_D3D11_BUFFER_RTV()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_BUFFER_RTV)), Is.EqualTo(8));
    }

    [Test]
    public void Size_of_D3D11_RENDER_TARGET_VIEW_DESC()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_RENDER_TARGET_VIEW_DESC)), Is.EqualTo(20));
    }

    [Test]
    public void Size_of_D3D11_TEX1D_ARRAY_RTV()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_TEX1D_ARRAY_RTV)), Is.EqualTo(12));
    }

    [Test]
    public void Size_of_D3D11_TEX1D_RTV()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_TEX1D_RTV)), Is.EqualTo(4));
    }

    [Test]
    public void Size_of_D3D11_TEX2D_ARRAY_RTV()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_TEX2D_ARRAY_RTV)), Is.EqualTo(12));
    }

    [Test]
    public void Size_of_D3D11_TEX2D_RTV()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_TEX2D_RTV)), Is.EqualTo(4));
    }

    [Test]
    public void Size_of_D3D11_TEX2DMS_ARRAY_RTV()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_TEX2DMS_ARRAY_RTV)), Is.EqualTo(8));
    }

    [Test]
    public void Size_of_D3D11_TEX2DMS_RTV()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_TEX2DMS_RTV)), Is.EqualTo(4));
    }

    [Test]
    public void Size_of_D3D11_TEX3D_RTV()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_TEX3D_RTV)), Is.EqualTo(12));
    }

    [Test]
    public void Size_of_D3D11_VIEWPORT()
    {
        Assert.That(Marshal.SizeOf(typeof(D3D11_VIEWPORT)), Is.EqualTo(24));
    }
}