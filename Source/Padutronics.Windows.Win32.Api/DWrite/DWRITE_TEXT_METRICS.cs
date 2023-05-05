namespace Padutronics.Windows.Win32.Api.DWrite;

public struct DWRITE_TEXT_METRICS
{
    public float left;
    public float top;
    public float width;
    public float widthIncludingTrailingWhitespace;
    public float height;
    public float layoutWidth;
    public float layoutHeight;
    public int maxBidiReorderingDepth;
    public int lineCount;
}