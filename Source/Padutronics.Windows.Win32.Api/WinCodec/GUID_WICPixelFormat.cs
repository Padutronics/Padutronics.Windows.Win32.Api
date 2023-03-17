using System;

namespace Padutronics.Windows.Win32.Api.WinCodec;

public static class GUID_WICPixelFormat
{
    public static Guid GUID_WICPixelFormatDontCare { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x00);

    public static Guid GUID_WICPixelFormat1bppIndexed { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x01);

    public static Guid GUID_WICPixelFormat2bppIndexed { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x02);

    public static Guid GUID_WICPixelFormat4bppIndexed { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x03);

    public static Guid GUID_WICPixelFormat8bppIndexed { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x04);

    public static Guid GUID_WICPixelFormatBlackWhite { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x05);

    public static Guid GUID_WICPixelFormat2bppGray { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x06);

    public static Guid GUID_WICPixelFormat4bppGray { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x07);

    public static Guid GUID_WICPixelFormat8bppGray { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x08);

    public static Guid GUID_WICPixelFormat8bppAlpha { get; } = new Guid(0xe6cd0116, 0xeeba, 0x4161, 0xaa, 0x85, 0x27, 0xdd, 0x9f, 0xb3, 0xa8, 0x95);

    public static Guid GUID_WICPixelFormat16bppBGR555 { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x09);

    public static Guid GUID_WICPixelFormat16bppBGR565 { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0a);

    public static Guid GUID_WICPixelFormat16bppBGRA5551 { get; } = new Guid(0x05ec7c2b, 0xf1e6, 0x4961, 0xad, 0x46, 0xe1, 0xcc, 0x81, 0x0a, 0x87, 0xd2);

    public static Guid GUID_WICPixelFormat16bppGray { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0b);

    public static Guid GUID_WICPixelFormat24bppBGR { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0c);

    public static Guid GUID_WICPixelFormat24bppRGB { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0d);

    public static Guid GUID_WICPixelFormat32bppBGR { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0e);

    public static Guid GUID_WICPixelFormat32bppBGRA { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0f);

    public static Guid GUID_WICPixelFormat32bppPBGRA { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x10);

    public static Guid GUID_WICPixelFormat32bppGrayFloat { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x11);

    public static Guid GUID_WICPixelFormat32bppRGB { get; } = new Guid(0xd98c6b95, 0x3efe, 0x47d6, 0xbb, 0x25, 0xeb, 0x17, 0x48, 0xab, 0x0c, 0xf1);

    public static Guid GUID_WICPixelFormat32bppRGBA { get; } = new Guid(0xf5c7ad2d, 0x6a8d, 0x43dd, 0xa7, 0xa8, 0xa2, 0x99, 0x35, 0x26, 0x1a, 0xe9);

    public static Guid GUID_WICPixelFormat32bppPRGBA { get; } = new Guid(0x3cc4a650, 0xa527, 0x4d37, 0xa9, 0x16, 0x31, 0x42, 0xc7, 0xeb, 0xed, 0xba);

    public static Guid GUID_WICPixelFormat48bppRGB { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x15);

    public static Guid GUID_WICPixelFormat48bppBGR { get; } = new Guid(0xe605a384, 0xb468, 0x46ce, 0xbb, 0x2e, 0x36, 0xf1, 0x80, 0xe6, 0x43, 0x13);

    public static Guid GUID_WICPixelFormat64bppRGB { get; } = new Guid(0xa1182111, 0x186d, 0x4d42, 0xbc, 0x6a, 0x9c, 0x83, 0x03, 0xa8, 0xdf, 0xf9);

    public static Guid GUID_WICPixelFormat64bppRGBA { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x16);

    public static Guid GUID_WICPixelFormat64bppBGRA { get; } = new Guid(0x1562ff7c, 0xd352, 0x46f9, 0x97, 0x9e, 0x42, 0x97, 0x6b, 0x79, 0x22, 0x46);

    public static Guid GUID_WICPixelFormat64bppPRGBA { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x17);

    public static Guid GUID_WICPixelFormat64bppPBGRA { get; } = new Guid(0x8c518e8e, 0xa4ec, 0x468b, 0xae, 0x70, 0xc9, 0xa3, 0x5a, 0x9c, 0x55, 0x30);

    public static Guid GUID_WICPixelFormat16bppGrayFixedPoint { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x13);

    public static Guid GUID_WICPixelFormat32bppBGR101010 { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x14);

    public static Guid GUID_WICPixelFormat48bppRGBFixedPoint { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x12);

    public static Guid GUID_WICPixelFormat48bppBGRFixedPoint { get; } = new Guid(0x49ca140e, 0xcab6, 0x493b, 0x9d, 0xdf, 0x60, 0x18, 0x7c, 0x37, 0x53, 0x2a);

    public static Guid GUID_WICPixelFormat96bppRGBFixedPoint { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x18);

    public static Guid GUID_WICPixelFormat96bppRGBFloat { get; } = new Guid(0xe3fed78f, 0xe8db, 0x4acf, 0x84, 0xc1, 0xe9, 0x7f, 0x61, 0x36, 0xb3, 0x27);

    public static Guid GUID_WICPixelFormat128bppRGBAFloat { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x19);

    public static Guid GUID_WICPixelFormat128bppPRGBAFloat { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1a);

    public static Guid GUID_WICPixelFormat128bppRGBFloat { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1b);

    public static Guid GUID_WICPixelFormat32bppCMYK { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1c);

    public static Guid GUID_WICPixelFormat64bppRGBAFixedPoint { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1d);

    public static Guid GUID_WICPixelFormat64bppBGRAFixedPoint { get; } = new Guid(0x356de33c, 0x54d2, 0x4a23, 0xbb, 0x4, 0x9b, 0x7b, 0xf9, 0xb1, 0xd4, 0x2d);

    public static Guid GUID_WICPixelFormat64bppRGBFixedPoint { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x40);

    public static Guid GUID_WICPixelFormat128bppRGBAFixedPoint { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1e);

    public static Guid GUID_WICPixelFormat128bppRGBFixedPoint { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x41);

    public static Guid GUID_WICPixelFormat64bppRGBAHalf { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3a);

    public static Guid GUID_WICPixelFormat64bppPRGBAHalf { get; } = new Guid(0x58ad26c2, 0xc623, 0x4d9d, 0xb3, 0x20, 0x38, 0x7e, 0x49, 0xf8, 0xc4, 0x42);

    public static Guid GUID_WICPixelFormat64bppRGBHalf { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x42);

    public static Guid GUID_WICPixelFormat48bppRGBHalf { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3b);

    public static Guid GUID_WICPixelFormat32bppRGBE { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3d);

    public static Guid GUID_WICPixelFormat16bppGrayHalf { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3e);

    public static Guid GUID_WICPixelFormat32bppGrayFixedPoint { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3f);

    public static Guid GUID_WICPixelFormat32bppRGBA1010102 { get; } = new Guid(0x25238D72, 0xFCF9, 0x4522, 0xb5, 0x14, 0x55, 0x78, 0xe5, 0xad, 0x55, 0xe0);

    public static Guid GUID_WICPixelFormat32bppRGBA1010102XR { get; } = new Guid(0x00DE6B9A, 0xC101, 0x434b, 0xb5, 0x02, 0xd0, 0x16, 0x5e, 0xe1, 0x12, 0x2c);

    public static Guid GUID_WICPixelFormat32bppR10G10B10A2 { get; } = new Guid(0x604e1bb5, 0x8a3c, 0x4b65, 0xb1, 0x1c, 0xbc, 0x0b, 0x8d, 0xd7, 0x5b, 0x7f);

    public static Guid GUID_WICPixelFormat32bppR10G10B10A2HDR10 { get; } = new Guid(0x9c215c5d, 0x1acc, 0x4f0e, 0xa4, 0xbc, 0x70, 0xfb, 0x3a, 0xe8, 0xfd, 0x28);

    public static Guid GUID_WICPixelFormat64bppCMYK { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1f);

    public static Guid GUID_WICPixelFormat24bpp3Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x20);

    public static Guid GUID_WICPixelFormat32bpp4Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x21);

    public static Guid GUID_WICPixelFormat40bpp5Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x22);

    public static Guid GUID_WICPixelFormat48bpp6Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x23);

    public static Guid GUID_WICPixelFormat56bpp7Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x24);

    public static Guid GUID_WICPixelFormat64bpp8Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x25);

    public static Guid GUID_WICPixelFormat48bpp3Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x26);

    public static Guid GUID_WICPixelFormat64bpp4Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x27);

    public static Guid GUID_WICPixelFormat80bpp5Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x28);

    public static Guid GUID_WICPixelFormat96bpp6Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x29);

    public static Guid GUID_WICPixelFormat112bpp7Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2a);

    public static Guid GUID_WICPixelFormat128bpp8Channels { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2b);

    public static Guid GUID_WICPixelFormat40bppCMYKAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2c);

    public static Guid GUID_WICPixelFormat80bppCMYKAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2d);

    public static Guid GUID_WICPixelFormat32bpp3ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2e);

    public static Guid GUID_WICPixelFormat40bpp4ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2f);

    public static Guid GUID_WICPixelFormat48bpp5ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x30);

    public static Guid GUID_WICPixelFormat56bpp6ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x31);

    public static Guid GUID_WICPixelFormat64bpp7ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x32);

    public static Guid GUID_WICPixelFormat72bpp8ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x33);

    public static Guid GUID_WICPixelFormat64bpp3ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x34);

    public static Guid GUID_WICPixelFormat80bpp4ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x35);

    public static Guid GUID_WICPixelFormat96bpp5ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x36);

    public static Guid GUID_WICPixelFormat112bpp6ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x37);

    public static Guid GUID_WICPixelFormat128bpp7ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x38);

    public static Guid GUID_WICPixelFormat144bpp8ChannelsAlpha { get; } = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x39);

    public static Guid GUID_WICPixelFormat8bppY { get; } = new Guid(0x91B4DB54, 0x2DF9, 0x42F0, 0xB4, 0x49, 0x29, 0x09, 0xBB, 0x3D, 0xF8, 0x8E);

    public static Guid GUID_WICPixelFormat8bppCb { get; } = new Guid(0x1339F224, 0x6BFE, 0x4C3E, 0x93, 0x02, 0xE4, 0xF3, 0xA6, 0xD0, 0xCA, 0x2A);

    public static Guid GUID_WICPixelFormat8bppCr { get; } = new Guid(0xB8145053, 0x2116, 0x49F0, 0x88, 0x35, 0xED, 0x84, 0x4B, 0x20, 0x5C, 0x51);

    public static Guid GUID_WICPixelFormat16bppCbCr { get; } = new Guid(0xFF95BA6E, 0x11E0, 0x4263, 0xBB, 0x45, 0x01, 0x72, 0x1F, 0x34, 0x60, 0xA4);

    public static Guid GUID_WICPixelFormat16bppYQuantizedDctCoefficients { get; } = new Guid(0xA355F433, 0x48E8, 0x4A42, 0x84, 0xD8, 0xE2, 0xAA, 0x26, 0xCA, 0x80, 0xA4);

    public static Guid GUID_WICPixelFormat16bppCbQuantizedDctCoefficients { get; } = new Guid(0xD2C4FF61, 0x56A5, 0x49C2, 0x8B, 0x5C, 0x4C, 0x19, 0x25, 0x96, 0x48, 0x37);

    public static Guid GUID_WICPixelFormat16bppCrQuantizedDctCoefficients { get; } = new Guid(0x2FE354F0, 0x1680, 0x42D8, 0x92, 0x31, 0xE7, 0x3C, 0x05, 0x65, 0xBF, 0xC1);
}