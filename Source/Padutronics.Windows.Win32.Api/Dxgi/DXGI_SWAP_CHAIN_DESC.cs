using Padutronics.Windows.Win32.Api.DxgiCommon;

namespace Padutronics.Windows.Win32.Api.Dxgi;

public struct DXGI_SWAP_CHAIN_DESC
{
    public DXGI_MODE_DESC BufferDesc;
    public DXGI_SAMPLE_DESC SampleDesc;
    public DXGI_USAGE BufferUsage;
    public int BufferCount;
    public nint OutputWindow;
    public bool Windowed;
    public DXGI_SWAP_EFFECT SwapEffect;
    public int Flags;
}