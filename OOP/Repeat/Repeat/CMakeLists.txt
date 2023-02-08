cmake_minimum_required(VERSION 3.23)
project(Repeat)

set(CMAKE_CXX_STANDARD 14)

include_directories(.)

add_executable(Repeat
        Repeat2.cpp Component.h)
