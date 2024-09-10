/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static SDL.SDL_Colorspace;
using static SDL.SDL_PixelFormat;

namespace SDL
{
    public enum SDL_PixelType
    {
        SDL_PIXELTYPE_UNKNOWN,
        SDL_PIXELTYPE_INDEX1,
        SDL_PIXELTYPE_INDEX4,
        SDL_PIXELTYPE_INDEX8,
        SDL_PIXELTYPE_PACKED8,
        SDL_PIXELTYPE_PACKED16,
        SDL_PIXELTYPE_PACKED32,
        SDL_PIXELTYPE_ARRAYU8,
        SDL_PIXELTYPE_ARRAYU16,
        SDL_PIXELTYPE_ARRAYU32,
        SDL_PIXELTYPE_ARRAYF16,
        SDL_PIXELTYPE_ARRAYF32,
        SDL_PIXELTYPE_INDEX2,
    }

    public enum SDL_BitmapOrder
    {
        SDL_BITMAPORDER_NONE,
        SDL_BITMAPORDER_4321,
        SDL_BITMAPORDER_1234,
    }

    public enum SDL_PackedOrder
    {
        SDL_PACKEDORDER_NONE,
        SDL_PACKEDORDER_XRGB,
        SDL_PACKEDORDER_RGBX,
        SDL_PACKEDORDER_ARGB,
        SDL_PACKEDORDER_RGBA,
        SDL_PACKEDORDER_XBGR,
        SDL_PACKEDORDER_BGRX,
        SDL_PACKEDORDER_ABGR,
        SDL_PACKEDORDER_BGRA,
    }

    public enum SDL_ArrayOrder
    {
        SDL_ARRAYORDER_NONE,
        SDL_ARRAYORDER_RGB,
        SDL_ARRAYORDER_RGBA,
        SDL_ARRAYORDER_ARGB,
        SDL_ARRAYORDER_BGR,
        SDL_ARRAYORDER_BGRA,
        SDL_ARRAYORDER_ABGR,
    }

    public enum SDL_PackedLayout
    {
        SDL_PACKEDLAYOUT_NONE,
        SDL_PACKEDLAYOUT_332,
        SDL_PACKEDLAYOUT_4444,
        SDL_PACKEDLAYOUT_1555,
        SDL_PACKEDLAYOUT_5551,
        SDL_PACKEDLAYOUT_565,
        SDL_PACKEDLAYOUT_8888,
        SDL_PACKEDLAYOUT_2101010,
        SDL_PACKEDLAYOUT_1010102,
    }

    [NativeTypeName("int")]
    public enum SDL_PixelFormat : uint
    {
        SDL_PIXELFORMAT_UNKNOWN = 0,
        SDL_PIXELFORMAT_INDEX1LSB = 0x11100100U,
        SDL_PIXELFORMAT_INDEX1MSB = 0x11200100U,
        SDL_PIXELFORMAT_INDEX2LSB = 0x1c100200U,
        SDL_PIXELFORMAT_INDEX2MSB = 0x1c200200U,
        SDL_PIXELFORMAT_INDEX4LSB = 0x12100400U,
        SDL_PIXELFORMAT_INDEX4MSB = 0x12200400U,
        SDL_PIXELFORMAT_INDEX8 = 0x13000801U,
        SDL_PIXELFORMAT_RGB332 = 0x14110801U,
        SDL_PIXELFORMAT_XRGB4444 = 0x15120c02U,
        SDL_PIXELFORMAT_XBGR4444 = 0x15520c02U,
        SDL_PIXELFORMAT_XRGB1555 = 0x15130f02U,
        SDL_PIXELFORMAT_XBGR1555 = 0x15530f02U,
        SDL_PIXELFORMAT_ARGB4444 = 0x15321002U,
        SDL_PIXELFORMAT_RGBA4444 = 0x15421002U,
        SDL_PIXELFORMAT_ABGR4444 = 0x15721002U,
        SDL_PIXELFORMAT_BGRA4444 = 0x15821002U,
        SDL_PIXELFORMAT_ARGB1555 = 0x15331002U,
        SDL_PIXELFORMAT_RGBA5551 = 0x15441002U,
        SDL_PIXELFORMAT_ABGR1555 = 0x15731002U,
        SDL_PIXELFORMAT_BGRA5551 = 0x15841002U,
        SDL_PIXELFORMAT_RGB565 = 0x15151002U,
        SDL_PIXELFORMAT_BGR565 = 0x15551002U,
        SDL_PIXELFORMAT_RGB24 = 0x17101803U,
        SDL_PIXELFORMAT_BGR24 = 0x17401803U,
        SDL_PIXELFORMAT_XRGB8888 = 0x16161804U,
        SDL_PIXELFORMAT_RGBX8888 = 0x16261804U,
        SDL_PIXELFORMAT_XBGR8888 = 0x16561804U,
        SDL_PIXELFORMAT_BGRX8888 = 0x16661804U,
        SDL_PIXELFORMAT_ARGB8888 = 0x16362004U,
        SDL_PIXELFORMAT_RGBA8888 = 0x16462004U,
        SDL_PIXELFORMAT_ABGR8888 = 0x16762004U,
        SDL_PIXELFORMAT_BGRA8888 = 0x16862004U,
        SDL_PIXELFORMAT_XRGB2101010 = 0x16172004U,
        SDL_PIXELFORMAT_XBGR2101010 = 0x16572004U,
        SDL_PIXELFORMAT_ARGB2101010 = 0x16372004U,
        SDL_PIXELFORMAT_ABGR2101010 = 0x16772004U,
        SDL_PIXELFORMAT_RGB48 = 0x18103006U,
        SDL_PIXELFORMAT_BGR48 = 0x18403006U,
        SDL_PIXELFORMAT_RGBA64 = 0x18204008U,
        SDL_PIXELFORMAT_ARGB64 = 0x18304008U,
        SDL_PIXELFORMAT_BGRA64 = 0x18504008U,
        SDL_PIXELFORMAT_ABGR64 = 0x18604008U,
        SDL_PIXELFORMAT_RGB48_FLOAT = 0x1a103006U,
        SDL_PIXELFORMAT_BGR48_FLOAT = 0x1a403006U,
        SDL_PIXELFORMAT_RGBA64_FLOAT = 0x1a204008U,
        SDL_PIXELFORMAT_ARGB64_FLOAT = 0x1a304008U,
        SDL_PIXELFORMAT_BGRA64_FLOAT = 0x1a504008U,
        SDL_PIXELFORMAT_ABGR64_FLOAT = 0x1a604008U,
        SDL_PIXELFORMAT_RGB96_FLOAT = 0x1b10600cU,
        SDL_PIXELFORMAT_BGR96_FLOAT = 0x1b40600cU,
        SDL_PIXELFORMAT_RGBA128_FLOAT = 0x1b208010U,
        SDL_PIXELFORMAT_ARGB128_FLOAT = 0x1b308010U,
        SDL_PIXELFORMAT_BGRA128_FLOAT = 0x1b508010U,
        SDL_PIXELFORMAT_ABGR128_FLOAT = 0x1b608010U,
        SDL_PIXELFORMAT_YV12 = 0x32315659U,
        SDL_PIXELFORMAT_IYUV = 0x56555949U,
        SDL_PIXELFORMAT_YUY2 = 0x32595559U,
        SDL_PIXELFORMAT_UYVY = 0x59565955U,
        SDL_PIXELFORMAT_YVYU = 0x55595659U,
        SDL_PIXELFORMAT_NV12 = 0x3231564eU,
        SDL_PIXELFORMAT_NV21 = 0x3132564eU,
        SDL_PIXELFORMAT_P010 = 0x30313050U,
        SDL_PIXELFORMAT_EXTERNAL_OES = 0x2053454fU,
    }

    public enum SDL_ColorType
    {
        SDL_COLOR_TYPE_UNKNOWN = 0,
        SDL_COLOR_TYPE_RGB = 1,
        SDL_COLOR_TYPE_YCBCR = 2,
    }

    public enum SDL_ColorRange
    {
        SDL_COLOR_RANGE_UNKNOWN = 0,
        SDL_COLOR_RANGE_LIMITED = 1,
        SDL_COLOR_RANGE_FULL = 2,
    }

    public enum SDL_ColorPrimaries
    {
        SDL_COLOR_PRIMARIES_UNKNOWN = 0,
        SDL_COLOR_PRIMARIES_BT709 = 1,
        SDL_COLOR_PRIMARIES_UNSPECIFIED = 2,
        SDL_COLOR_PRIMARIES_BT470M = 4,
        SDL_COLOR_PRIMARIES_BT470BG = 5,
        SDL_COLOR_PRIMARIES_BT601 = 6,
        SDL_COLOR_PRIMARIES_SMPTE240 = 7,
        SDL_COLOR_PRIMARIES_GENERIC_FILM = 8,
        SDL_COLOR_PRIMARIES_BT2020 = 9,
        SDL_COLOR_PRIMARIES_XYZ = 10,
        SDL_COLOR_PRIMARIES_SMPTE431 = 11,
        SDL_COLOR_PRIMARIES_SMPTE432 = 12,
        SDL_COLOR_PRIMARIES_EBU3213 = 22,
        SDL_COLOR_PRIMARIES_CUSTOM = 31,
    }

    public enum SDL_TransferCharacteristics
    {
        SDL_TRANSFER_CHARACTERISTICS_UNKNOWN = 0,
        SDL_TRANSFER_CHARACTERISTICS_BT709 = 1,
        SDL_TRANSFER_CHARACTERISTICS_UNSPECIFIED = 2,
        SDL_TRANSFER_CHARACTERISTICS_GAMMA22 = 4,
        SDL_TRANSFER_CHARACTERISTICS_GAMMA28 = 5,
        SDL_TRANSFER_CHARACTERISTICS_BT601 = 6,
        SDL_TRANSFER_CHARACTERISTICS_SMPTE240 = 7,
        SDL_TRANSFER_CHARACTERISTICS_LINEAR = 8,
        SDL_TRANSFER_CHARACTERISTICS_LOG100 = 9,
        SDL_TRANSFER_CHARACTERISTICS_LOG100_SQRT10 = 10,
        SDL_TRANSFER_CHARACTERISTICS_IEC61966 = 11,
        SDL_TRANSFER_CHARACTERISTICS_BT1361 = 12,
        SDL_TRANSFER_CHARACTERISTICS_SRGB = 13,
        SDL_TRANSFER_CHARACTERISTICS_BT2020_10BIT = 14,
        SDL_TRANSFER_CHARACTERISTICS_BT2020_12BIT = 15,
        SDL_TRANSFER_CHARACTERISTICS_PQ = 16,
        SDL_TRANSFER_CHARACTERISTICS_SMPTE428 = 17,
        SDL_TRANSFER_CHARACTERISTICS_HLG = 18,
        SDL_TRANSFER_CHARACTERISTICS_CUSTOM = 31,
    }

    public enum SDL_MatrixCoefficients
    {
        SDL_MATRIX_COEFFICIENTS_IDENTITY = 0,
        SDL_MATRIX_COEFFICIENTS_BT709 = 1,
        SDL_MATRIX_COEFFICIENTS_UNSPECIFIED = 2,
        SDL_MATRIX_COEFFICIENTS_FCC = 4,
        SDL_MATRIX_COEFFICIENTS_BT470BG = 5,
        SDL_MATRIX_COEFFICIENTS_BT601 = 6,
        SDL_MATRIX_COEFFICIENTS_SMPTE240 = 7,
        SDL_MATRIX_COEFFICIENTS_YCGCO = 8,
        SDL_MATRIX_COEFFICIENTS_BT2020_NCL = 9,
        SDL_MATRIX_COEFFICIENTS_BT2020_CL = 10,
        SDL_MATRIX_COEFFICIENTS_SMPTE2085 = 11,
        SDL_MATRIX_COEFFICIENTS_CHROMA_DERIVED_NCL = 12,
        SDL_MATRIX_COEFFICIENTS_CHROMA_DERIVED_CL = 13,
        SDL_MATRIX_COEFFICIENTS_ICTCP = 14,
        SDL_MATRIX_COEFFICIENTS_CUSTOM = 31,
    }

    public enum SDL_ChromaLocation
    {
        SDL_CHROMA_LOCATION_NONE = 0,
        SDL_CHROMA_LOCATION_LEFT = 1,
        SDL_CHROMA_LOCATION_CENTER = 2,
        SDL_CHROMA_LOCATION_TOPLEFT = 3,
    }

    [NativeTypeName("int")]
    public enum SDL_Colorspace : uint
    {
        SDL_COLORSPACE_UNKNOWN = 0,
        SDL_COLORSPACE_SRGB = 0x120005a0U,
        SDL_COLORSPACE_SRGB_LINEAR = 0x12000500U,
        SDL_COLORSPACE_HDR10 = 0x12002600U,
        SDL_COLORSPACE_JPEG = 0x220004c6U,
        SDL_COLORSPACE_BT601_LIMITED = 0x211018c6U,
        SDL_COLORSPACE_BT601_FULL = 0x221018c6U,
        SDL_COLORSPACE_BT709_LIMITED = 0x21100421U,
        SDL_COLORSPACE_BT709_FULL = 0x22100421U,
        SDL_COLORSPACE_BT2020_LIMITED = 0x21102609U,
        SDL_COLORSPACE_BT2020_FULL = 0x22102609U,
    }

    public partial struct SDL_Color
    {
        [NativeTypeName("Uint8")]
        public byte r;

        [NativeTypeName("Uint8")]
        public byte g;

        [NativeTypeName("Uint8")]
        public byte b;

        [NativeTypeName("Uint8")]
        public byte a;
    }

    public partial struct SDL_FColor
    {
        public float r;

        public float g;

        public float b;

        public float a;
    }

    public unsafe partial struct SDL_Palette
    {
        public int ncolors;

        public SDL_Color* colors;

        [NativeTypeName("Uint32")]
        public uint version;

        public int refcount;
    }

    public partial struct SDL_PixelFormatDetails
    {
        public SDL_PixelFormat format;

        [NativeTypeName("Uint8")]
        public byte bits_per_pixel;

        [NativeTypeName("Uint8")]
        public byte bytes_per_pixel;

        [NativeTypeName("Uint8[2]")]
        public _padding_e__FixedBuffer padding;

        [NativeTypeName("Uint32")]
        public uint Rmask;

        [NativeTypeName("Uint32")]
        public uint Gmask;

        [NativeTypeName("Uint32")]
        public uint Bmask;

        [NativeTypeName("Uint32")]
        public uint Amask;

        [NativeTypeName("Uint8")]
        public byte Rbits;

        [NativeTypeName("Uint8")]
        public byte Gbits;

        [NativeTypeName("Uint8")]
        public byte Bbits;

        [NativeTypeName("Uint8")]
        public byte Abits;

        [NativeTypeName("Uint8")]
        public byte Rshift;

        [NativeTypeName("Uint8")]
        public byte Gshift;

        [NativeTypeName("Uint8")]
        public byte Bshift;

        [NativeTypeName("Uint8")]
        public byte Ashift;

        [InlineArray(2)]
        public partial struct _padding_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetPixelFormatName(SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetMasksForPixelFormat(SDL_PixelFormat format, int* bpp, [NativeTypeName("Uint32 *")] uint* Rmask, [NativeTypeName("Uint32 *")] uint* Gmask, [NativeTypeName("Uint32 *")] uint* Bmask, [NativeTypeName("Uint32 *")] uint* Amask);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PixelFormat SDL_GetPixelFormatForMasks(int bpp, [NativeTypeName("Uint32")] uint Rmask, [NativeTypeName("Uint32")] uint Gmask, [NativeTypeName("Uint32")] uint Bmask, [NativeTypeName("Uint32")] uint Amask);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const SDL_PixelFormatDetails *")]
        public static extern SDL_PixelFormatDetails* SDL_GetPixelFormatDetails(SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Palette* SDL_CreatePalette(int ncolors);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetPaletteColors(SDL_Palette* palette, [NativeTypeName("const SDL_Color *")] SDL_Color* colors, int firstcolor, int ncolors);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyPalette(SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_MapRGB([NativeTypeName("const SDL_PixelFormatDetails *")] SDL_PixelFormatDetails* format, [NativeTypeName("const SDL_Palette *")] SDL_Palette* palette, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_MapRGBA([NativeTypeName("const SDL_PixelFormatDetails *")] SDL_PixelFormatDetails* format, [NativeTypeName("const SDL_Palette *")] SDL_Palette* palette, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetRGB([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormatDetails *")] SDL_PixelFormatDetails* format, [NativeTypeName("const SDL_Palette *")] SDL_Palette* palette, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetRGBA([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormatDetails *")] SDL_PixelFormatDetails* format, [NativeTypeName("const SDL_Palette *")] SDL_Palette* palette, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [NativeTypeName("#define SDL_ALPHA_OPAQUE 255")]
        public const int SDL_ALPHA_OPAQUE = 255;

        [NativeTypeName("#define SDL_ALPHA_TRANSPARENT 0")]
        public const int SDL_ALPHA_TRANSPARENT = 0;

        [NativeTypeName("#define SDL_PIXELFORMAT_RGBA32 SDL_PIXELFORMAT_ABGR8888")]
        public const SDL_PixelFormat SDL_PIXELFORMAT_RGBA32 = SDL_PIXELFORMAT_ABGR8888;

        [NativeTypeName("#define SDL_PIXELFORMAT_ARGB32 SDL_PIXELFORMAT_BGRA8888")]
        public const SDL_PixelFormat SDL_PIXELFORMAT_ARGB32 = SDL_PIXELFORMAT_BGRA8888;

        [NativeTypeName("#define SDL_PIXELFORMAT_BGRA32 SDL_PIXELFORMAT_ARGB8888")]
        public const SDL_PixelFormat SDL_PIXELFORMAT_BGRA32 = SDL_PIXELFORMAT_ARGB8888;

        [NativeTypeName("#define SDL_PIXELFORMAT_ABGR32 SDL_PIXELFORMAT_RGBA8888")]
        public const SDL_PixelFormat SDL_PIXELFORMAT_ABGR32 = SDL_PIXELFORMAT_RGBA8888;

        [NativeTypeName("#define SDL_PIXELFORMAT_RGBX32 SDL_PIXELFORMAT_XBGR8888")]
        public const SDL_PixelFormat SDL_PIXELFORMAT_RGBX32 = SDL_PIXELFORMAT_XBGR8888;

        [NativeTypeName("#define SDL_PIXELFORMAT_XRGB32 SDL_PIXELFORMAT_BGRX8888")]
        public const SDL_PixelFormat SDL_PIXELFORMAT_XRGB32 = SDL_PIXELFORMAT_BGRX8888;

        [NativeTypeName("#define SDL_PIXELFORMAT_BGRX32 SDL_PIXELFORMAT_XRGB8888")]
        public const SDL_PixelFormat SDL_PIXELFORMAT_BGRX32 = SDL_PIXELFORMAT_XRGB8888;

        [NativeTypeName("#define SDL_PIXELFORMAT_XBGR32 SDL_PIXELFORMAT_RGBX8888")]
        public const SDL_PixelFormat SDL_PIXELFORMAT_XBGR32 = SDL_PIXELFORMAT_RGBX8888;

        [NativeTypeName("#define SDL_COLORSPACE_RGB_DEFAULT SDL_COLORSPACE_SRGB")]
        public const SDL_Colorspace SDL_COLORSPACE_RGB_DEFAULT = SDL_COLORSPACE_SRGB;

        [NativeTypeName("#define SDL_COLORSPACE_YUV_DEFAULT SDL_COLORSPACE_JPEG")]
        public const SDL_Colorspace SDL_COLORSPACE_YUV_DEFAULT = SDL_COLORSPACE_JPEG;
    }
}