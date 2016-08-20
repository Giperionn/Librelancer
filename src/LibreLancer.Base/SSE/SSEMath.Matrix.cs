﻿using System;
using System.Security;

namespace LibreLancer
{
    static partial class SSEMath
    {
        [SuppressUnmanagedCodeSecurity]
        public delegate void MatrixMultiplyDelegate(ref Matrix4 a, ref Matrix4 b, out Matrix4 outmat);
        [AsmMethod("_multiplyCodeUnix", "_multiplyCodeWin")]
        public static MatrixMultiplyDelegate MatrixMultiply;
        static byte[] _multiplyCodeUnix = new byte[] {
            0x0f, 0x10, 0x06, 0x0f, 0x10, 0x4e, 0x10, 0x0f, 0x10, 0x56, 0x20, 0x0f, 0x10, 0x5e, 0x30, 0x48, 0xc7, 0xc0, 0x30, 0x00, 0x00, 0x00, 0xf3, 0x0f, 0x10, 0x24, 0x07, 0x0f, 0xc6, 0xe4, 0x00, 0x0f, 0x59, 0xe0, 0x0f, 0x10, 0xec, 0xf3, 0x0f, 0x10, 0x64, 0x07, 0x04, 0x0f, 0xc6, 0xe4, 0x00, 0x0f, 0x59, 0xe1, 0x0f, 0x58, 0xec, 0xf3, 0x0f, 0x10, 0x64, 0x07, 0x08, 0x0f, 0xc6, 0xe4, 0x00, 0x0f, 0x59, 0xe2, 0x0f, 0x58, 0xec, 0xf3, 0x0f, 0x10, 0x64, 0x07, 0x0c, 0x0f, 0xc6, 0xe4, 0x00, 0x0f, 0x59, 0xe3, 0x0f, 0x58, 0xec, 0x0f, 0x11, 0x2c, 0x02, 0x48, 0x83, 0xe8, 0x10, 0x7d, 0xb7, 0xc3
        };
        static byte[] _multiplyCodeWin = new byte[] {
            0x0f, 0x10, 0x02, 0x0f, 0x10, 0x4a, 0x10, 0x0f, 0x10, 0x52, 0x20, 0x0f, 0x10, 0x5a, 0x30, 0x48, 0xc7, 0xc0, 0x30, 0x00, 0x00, 0x00, 0xf3, 0x0f, 0x10, 0x24, 0x01, 0x0f, 0xc6, 0xe4, 0x00, 0x0f, 0x59, 0xe0, 0x0f, 0x10, 0xec, 0xf3, 0x0f, 0x10, 0x64, 0x01, 0x04, 0x0f, 0xc6, 0xe4, 0x00, 0x0f, 0x59, 0xe1, 0x0f, 0x58, 0xec, 0xf3, 0x0f, 0x10, 0x64, 0x01, 0x08, 0x0f, 0xc6, 0xe4, 0x00, 0x0f, 0x59, 0xe2, 0x0f, 0x58, 0xec, 0xf3, 0x0f, 0x10, 0x64, 0x01, 0x0c, 0x0f, 0xc6, 0xe4, 0x00, 0x0f, 0x59, 0xe3, 0x0f, 0x58, 0xec, 0x41, 0x0f, 0x11, 0x2c, 0x00, 0x48, 0x83, 0xe8, 0x10, 0x7d, 0xb6, 0xc3
        };

        [SuppressUnmanagedCodeSecurity]
        public delegate void MatrixInvertDelegate(ref Matrix4 mat, out Matrix4 result);
        [AsmMethod("_invertCodeUnix", "_invertCodeWin")]
        public static MatrixInvertDelegate MatrixInvert;
        static byte[] _invertCodeUnix = new byte[] {
            0x55, 0x48, 0x89, 0xe5, 0xf3, 0x0f, 0x7e, 0x07, 0x66, 0x0f, 0x16, 0x47, 0x10, 0xf3, 0x44, 0x0f, 0x7e, 0x67, 0x20, 0x66, 0x44, 0x0f, 0x16, 0x67, 0x30, 0x66, 0x0f, 0x28, 0xc8, 0x41, 0x0f, 0xc6, 0xcc, 0x88, 0x0f, 0x28, 0xd1, 0x44, 0x0f, 0xc6, 0xe0, 0xdd, 0xf3, 0x0f, 0x7e, 0x47, 0x08, 0x66, 0x0f, 0x16, 0x47, 0x18, 0xf3, 0x44, 0x0f, 0x7e, 0x6f, 0x28, 0x66, 0x44, 0x0f, 0x16, 0x6f, 0x38, 0x66, 0x0f, 0x28, 0xc8, 0x41, 0x0f, 0xc6, 0xcd, 0x88, 0x44, 0x0f, 0xc6, 0xe8, 0xdd, 0x44, 0x0f, 0x28, 0xc9, 0x45, 0x0f, 0x59, 0xcd, 0x45, 0x0f, 0xc6, 0xc9, 0xb1, 0x41, 0x0f, 0x28, 0xec, 0x0f, 0x59, 0xe9, 0x44, 0x0f, 0x28, 0xc1, 0x41, 0x0f, 0x28, 0xfc, 0x66, 0x0f, 0xc6, 0xff, 0x01, 0x41, 0x0f, 0x59, 0xfd, 0x41, 0x0f, 0x28, 0xc0, 0x66, 0x0f, 0xc6, 0xc0, 0x01, 0x66, 0x0f, 0x29, 0x45, 0xf0, 0x66, 0x0f, 0x28, 0xf0, 0x0f, 0x28, 0xc2, 0x0f, 0x28, 0xd8, 0x41, 0x0f, 0x59, 0xdc, 0x0f, 0xc6, 0xdb, 0xb1, 0x0f, 0x28, 0xcb, 0x41, 0x0f, 0x59, 0xcd, 0x0f, 0x29, 0x4d, 0xe0, 0x44, 0x0f, 0x28, 0xd3, 0x44, 0x0f, 0x59, 0xd6, 0x0f, 0x28, 0xcb, 0x66, 0x0f, 0xc6, 0xc9, 0x01, 0x41, 0x0f, 0x59, 0xcd, 0x0f, 0x29, 0x4d, 0xd0, 0x41, 0x0f, 0x59, 0xd8, 0x0f, 0x28, 0xc8, 0x41, 0x0f, 0x59, 0xcd, 0x0f, 0xc6, 0xc9, 0xb1, 0x0f, 0x59, 0xd6, 0x0f, 0x59, 0xf1, 0x0f, 0x29, 0x75, 0xc0, 0x41, 0x0f, 0x28, 0xf4, 0x0f, 0x59, 0xf1, 0x44, 0x0f, 0x29, 0x45, 0xa0, 0x44, 0x0f, 0x59, 0xc1, 0x44, 0x0f, 0x29, 0x45, 0xb0, 0x66, 0x0f, 0xc6, 0xc9, 0x01, 0x41, 0x0f, 0x59, 0xcc, 0x0f, 0xc6, 0xd2, 0xb1, 0x45, 0x0f, 0x28, 0xfd, 0x44, 0x0f, 0x59, 0xfa, 0x41, 0x0f, 0x28, 0xe4, 0x0f, 0x59, 0xe2, 0x0f, 0x29, 0x65, 0x90, 0x66, 0x0f, 0xc6, 0xd2, 0x01, 0x45, 0x0f, 0x28, 0xc5, 0x45, 0x0f, 0x28, 0xdd, 0x44, 0x0f, 0x59, 0xea, 0x41, 0x0f, 0x59, 0xd4, 0x45, 0x0f, 0x28, 0xf4, 0x45, 0x0f, 0x59, 0xe1, 0x0f, 0x28, 0xe0, 0x41, 0x0f, 0x59, 0xc1, 0x66, 0x45, 0x0f, 0xc6, 0xc9, 0x01, 0x45, 0x0f, 0x59, 0xf1, 0x45, 0x0f, 0x5c, 0xf4, 0x44, 0x0f, 0x28, 0xe4, 0x45, 0x0f, 0x59, 0xcc, 0x44, 0x0f, 0x5c, 0xc8, 0x0f, 0xc6, 0xed, 0xb1, 0x44, 0x0f, 0x59, 0xc5, 0x45, 0x0f, 0x58, 0xc6, 0x41, 0x0f, 0x28, 0xc4, 0x0f, 0x59, 0xc5, 0x66, 0x0f, 0xc6, 0xed, 0x01, 0x44, 0x0f, 0x59, 0xdd, 0x45, 0x0f, 0x5c, 0xc3, 0x41, 0x0f, 0x59, 0xec, 0x0f, 0x5c, 0xe8, 0x0f, 0xc6, 0xff, 0xb1, 0x0f, 0x28, 0x45, 0xf0, 0x0f, 0x59, 0xc7, 0x41, 0x0f, 0x58, 0xc0, 0x0f, 0x28, 0x65, 0xa0, 0x0f, 0x59, 0xe7, 0x66, 0x0f, 0xc6, 0xe4, 0x01, 0x0f, 0x5c, 0xc4, 0x44, 0x0f, 0x28, 0xc0, 0x41, 0x0f, 0x28, 0xc4, 0x0f, 0x59, 0xc7, 0x66, 0x0f, 0xc6, 0xff, 0x01, 0x41, 0x0f, 0x59, 0xfc, 0x0f, 0x5c, 0xf8, 0x66, 0x0f, 0xc6, 0xff, 0x01, 0x0f, 0x28, 0x45, 0xe0, 0x0f, 0x58, 0xc7, 0x66, 0x0f, 0xc6, 0xed, 0x01, 0x44, 0x0f, 0x5c, 0xd5, 0x0f, 0x28, 0x6d, 0xd0, 0x0f, 0x5c, 0xe8, 0x66, 0x0f, 0xc6, 0xdb, 0x01, 0x44, 0x0f, 0x5c, 0xd3, 0x66, 0x45, 0x0f, 0xc6, 0xc9, 0x01, 0x44, 0x0f, 0x5c, 0x4d, 0xc0, 0x0f, 0x58, 0xf5, 0x66, 0x0f, 0x28, 0x45, 0xb0, 0x66, 0x0f, 0xc6, 0xc0, 0x01, 0x41, 0x0f, 0x58, 0xc1, 0x0f, 0x5c, 0xf1, 0x44, 0x0f, 0x58, 0xf8, 0x44, 0x0f, 0x5c, 0x55, 0x90, 0x45, 0x0f, 0x5c, 0xfd, 0x41, 0x0f, 0x58, 0xd2, 0x45, 0x0f, 0x59, 0xe0, 0x41, 0x0f, 0x28, 0xc4, 0x66, 0x0f, 0xc6, 0xc0, 0x01, 0x41, 0x0f, 0x58, 0xc4, 0xf3, 0x0f, 0x16, 0xc8, 0xf3, 0x0f, 0x58, 0xc8, 0x0f, 0xc6, 0xc0, 0xb0, 0xf3, 0x0f, 0x10, 0xc1, 0xf3, 0x0f, 0x53, 0xc0, 0x0f, 0x28, 0xd8, 0xf3, 0x0f, 0x58, 0xdb, 0xf3, 0x0f, 0x59, 0xc0, 0xf3, 0x0f, 0x59, 0xc1, 0xf3, 0x0f, 0x5c, 0xd8, 0x0f, 0xc6, 0xdb, 0x00, 0x44, 0x0f, 0x59, 0xc3, 0x44, 0x0f, 0x11, 0x06, 0x44, 0x0f, 0x59, 0xfb, 0x44, 0x0f, 0x11, 0x7e, 0x10, 0x0f, 0x59, 0xf3, 0x0f, 0x11, 0x76, 0x20, 0x0f, 0x59, 0xda, 0x0f, 0x11, 0x5e, 0x30, 0x5d, 0xc3
        };
        static byte[] _invertCodeWin = new byte[] {
            0x55, 0x48, 0x89, 0xe5, 0xf3, 0x0f, 0x7e, 0x01, 0x66, 0x0f, 0x16, 0x41, 0x10, 0xf3, 0x44, 0x0f, 0x7e, 0x61, 0x20, 0x66, 0x44, 0x0f, 0x16, 0x61, 0x30, 0x66, 0x0f, 0x28, 0xc8, 0x41, 0x0f, 0xc6, 0xcc, 0x88, 0x0f, 0x28, 0xd1, 0x44, 0x0f, 0xc6, 0xe0, 0xdd, 0xf3, 0x0f, 0x7e, 0x41, 0x08, 0x66, 0x0f, 0x16, 0x41, 0x18, 0xf3, 0x44, 0x0f, 0x7e, 0x69, 0x28, 0x66, 0x44, 0x0f, 0x16, 0x69, 0x38, 0x66, 0x0f, 0x28, 0xc8, 0x41, 0x0f, 0xc6, 0xcd, 0x88, 0x44, 0x0f, 0xc6, 0xe8, 0xdd, 0x44, 0x0f, 0x28, 0xc9, 0x45, 0x0f, 0x59, 0xcd, 0x45, 0x0f, 0xc6, 0xc9, 0xb1, 0x41, 0x0f, 0x28, 0xec, 0x0f, 0x59, 0xe9, 0x44, 0x0f, 0x28, 0xc1, 0x41, 0x0f, 0x28, 0xfc, 0x66, 0x0f, 0xc6, 0xff, 0x01, 0x41, 0x0f, 0x59, 0xfd, 0x41, 0x0f, 0x28, 0xc0, 0x66, 0x0f, 0xc6, 0xc0, 0x01, 0x66, 0x0f, 0x29, 0x45, 0xf0, 0x66, 0x0f, 0x28, 0xf0, 0x0f, 0x28, 0xc2, 0x0f, 0x28, 0xd8, 0x41, 0x0f, 0x59, 0xdc, 0x0f, 0xc6, 0xdb, 0xb1, 0x0f, 0x28, 0xcb, 0x41, 0x0f, 0x59, 0xcd, 0x0f, 0x29, 0x4d, 0xe0, 0x44, 0x0f, 0x28, 0xd3, 0x44, 0x0f, 0x59, 0xd6, 0x0f, 0x28, 0xcb, 0x66, 0x0f, 0xc6, 0xc9, 0x01, 0x41, 0x0f, 0x59, 0xcd, 0x0f, 0x29, 0x4d, 0xd0, 0x41, 0x0f, 0x59, 0xd8, 0x0f, 0x28, 0xc8, 0x41, 0x0f, 0x59, 0xcd, 0x0f, 0xc6, 0xc9, 0xb1, 0x0f, 0x59, 0xd6, 0x0f, 0x59, 0xf1, 0x0f, 0x29, 0x75, 0xc0, 0x41, 0x0f, 0x28, 0xf4, 0x0f, 0x59, 0xf1, 0x44, 0x0f, 0x29, 0x45, 0xa0, 0x44, 0x0f, 0x59, 0xc1, 0x44, 0x0f, 0x29, 0x45, 0xb0, 0x66, 0x0f, 0xc6, 0xc9, 0x01, 0x41, 0x0f, 0x59, 0xcc, 0x0f, 0xc6, 0xd2, 0xb1, 0x45, 0x0f, 0x28, 0xfd, 0x44, 0x0f, 0x59, 0xfa, 0x41, 0x0f, 0x28, 0xe4, 0x0f, 0x59, 0xe2, 0x0f, 0x29, 0x65, 0x90, 0x66, 0x0f, 0xc6, 0xd2, 0x01, 0x45, 0x0f, 0x28, 0xc5, 0x45, 0x0f, 0x28, 0xdd, 0x44, 0x0f, 0x59, 0xea, 0x41, 0x0f, 0x59, 0xd4, 0x45, 0x0f, 0x28, 0xf4, 0x45, 0x0f, 0x59, 0xe1, 0x0f, 0x28, 0xe0, 0x41, 0x0f, 0x59, 0xc1, 0x66, 0x45, 0x0f, 0xc6, 0xc9, 0x01, 0x45, 0x0f, 0x59, 0xf1, 0x45, 0x0f, 0x5c, 0xf4, 0x44, 0x0f, 0x28, 0xe4, 0x45, 0x0f, 0x59, 0xcc, 0x44, 0x0f, 0x5c, 0xc8, 0x0f, 0xc6, 0xed, 0xb1, 0x44, 0x0f, 0x59, 0xc5, 0x45, 0x0f, 0x58, 0xc6, 0x41, 0x0f, 0x28, 0xc4, 0x0f, 0x59, 0xc5, 0x66, 0x0f, 0xc6, 0xed, 0x01, 0x44, 0x0f, 0x59, 0xdd, 0x45, 0x0f, 0x5c, 0xc3, 0x41, 0x0f, 0x59, 0xec, 0x0f, 0x5c, 0xe8, 0x0f, 0xc6, 0xff, 0xb1, 0x0f, 0x28, 0x45, 0xf0, 0x0f, 0x59, 0xc7, 0x41, 0x0f, 0x58, 0xc0, 0x0f, 0x28, 0x65, 0xa0, 0x0f, 0x59, 0xe7, 0x66, 0x0f, 0xc6, 0xe4, 0x01, 0x0f, 0x5c, 0xc4, 0x44, 0x0f, 0x28, 0xc0, 0x41, 0x0f, 0x28, 0xc4, 0x0f, 0x59, 0xc7, 0x66, 0x0f, 0xc6, 0xff, 0x01, 0x41, 0x0f, 0x59, 0xfc, 0x0f, 0x5c, 0xf8, 0x66, 0x0f, 0xc6, 0xff, 0x01, 0x0f, 0x28, 0x45, 0xe0, 0x0f, 0x58, 0xc7, 0x66, 0x0f, 0xc6, 0xed, 0x01, 0x44, 0x0f, 0x5c, 0xd5, 0x0f, 0x28, 0x6d, 0xd0, 0x0f, 0x5c, 0xe8, 0x66, 0x0f, 0xc6, 0xdb, 0x01, 0x44, 0x0f, 0x5c, 0xd3, 0x66, 0x45, 0x0f, 0xc6, 0xc9, 0x01, 0x44, 0x0f, 0x5c, 0x4d, 0xc0, 0x0f, 0x58, 0xf5, 0x66, 0x0f, 0x28, 0x45, 0xb0, 0x66, 0x0f, 0xc6, 0xc0, 0x01, 0x41, 0x0f, 0x58, 0xc1, 0x0f, 0x5c, 0xf1, 0x44, 0x0f, 0x58, 0xf8, 0x44, 0x0f, 0x5c, 0x55, 0x90, 0x45, 0x0f, 0x5c, 0xfd, 0x41, 0x0f, 0x58, 0xd2, 0x45, 0x0f, 0x59, 0xe0, 0x41, 0x0f, 0x28, 0xc4, 0x66, 0x0f, 0xc6, 0xc0, 0x01, 0x41, 0x0f, 0x58, 0xc4, 0xf3, 0x0f, 0x16, 0xc8, 0xf3, 0x0f, 0x58, 0xc8, 0x0f, 0xc6, 0xc0, 0xb0, 0xf3, 0x0f, 0x10, 0xc1, 0xf3, 0x0f, 0x53, 0xc0, 0x0f, 0x28, 0xd8, 0xf3, 0x0f, 0x58, 0xdb, 0xf3, 0x0f, 0x59, 0xc0, 0xf3, 0x0f, 0x59, 0xc1, 0xf3, 0x0f, 0x5c, 0xd8, 0x0f, 0xc6, 0xdb, 0x00, 0x44, 0x0f, 0x59, 0xc3, 0x44, 0x0f, 0x11, 0x02, 0x44, 0x0f, 0x59, 0xfb, 0x44, 0x0f, 0x11, 0x7a, 0x10, 0x0f, 0x59, 0xf3, 0x0f, 0x11, 0x72, 0x20, 0x0f, 0x59, 0xda, 0x0f, 0x11, 0x5a, 0x30, 0x5d, 0xc3
        };
    }
}
