cmake_minimum_required(VERSION 3.8)

set(PROJECT_NAME Padutronics.Windows.Win32.Api.CWrapper)

project(${PROJECT_NAME})

set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED True)

add_library(
    ${PROJECT_NAME} SHARED
)