cmake_minimum_required(VERSION 3.8)

set(PROJECT_NAME Padutronics.Windows.Win32.Api.CWrapper)

project(${PROJECT_NAME})

set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED True)

if (MSVC)
    add_compile_options(/W4 /WX)
endif()

add_library(
    ${PROJECT_NAME} SHARED
    D2D1/ID2D1Bitmap.cpp
    D2D1/ID2D1Factory.cpp
    D2D1/ID2D1PathGeometry.cpp
    D2D1/ID2D1RenderTarget.cpp
    D2D1/ID2D1SimplifiedGeometrySink.cpp
    D2D1/ID2D1SolidColorBrush.cpp
    D3D11/ID3D11Device.cpp
    D3D11/ID3D11DeviceContext.cpp
    DWrite/IDWriteFactory.cpp
    Dxgi/IDXGIFactory.cpp
    Dxgi/IDXGISwapChain.cpp
    Unknwn/IUnknown.cpp
    WinCodec/IWICBitmapDecoder.cpp
    WinCodec/IWICFormatConverter.cpp
    WinCodec/IWICImagingFactory.cpp
)