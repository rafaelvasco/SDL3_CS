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

namespace SDL
{
    public unsafe partial struct SDL_MessageBoxButtonData
    {
        public SDL_MessageBoxButtonFlags flags;

        public int buttonID;

        [NativeTypeName("const char *")]
        public byte* text;
    }

    public partial struct SDL_MessageBoxColor
    {
        [NativeTypeName("Uint8")]
        public byte r;

        [NativeTypeName("Uint8")]
        public byte g;

        [NativeTypeName("Uint8")]
        public byte b;
    }

    public enum SDL_MessageBoxColorType
    {
        SDL_MESSAGEBOX_COLOR_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_TEXT,
        SDL_MESSAGEBOX_COLOR_BUTTON_BORDER,
        SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED,
        SDL_MESSAGEBOX_COLOR_MAX,
    }

    public partial struct SDL_MessageBoxColorScheme
    {
        [NativeTypeName("SDL_MessageBoxColor[5]")]
        public _colors_e__FixedBuffer colors;

        [InlineArray(5)]
        public partial struct _colors_e__FixedBuffer
        {
            public SDL_MessageBoxColor e0;
        }
    }

    public unsafe partial struct SDL_MessageBoxData
    {
        public SDL_MessageBoxFlags flags;

        public SDL_Window* window;

        [NativeTypeName("const char *")]
        public byte* title;

        [NativeTypeName("const char *")]
        public byte* message;

        public int numbuttons;

        [NativeTypeName("const SDL_MessageBoxButtonData *")]
        public SDL_MessageBoxButtonData* buttons;

        [NativeTypeName("const SDL_MessageBoxColorScheme *")]
        public SDL_MessageBoxColorScheme* colorScheme;
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ShowMessageBox([NativeTypeName("const SDL_MessageBoxData *")] SDL_MessageBoxData* messageboxdata, int* buttonid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ShowSimpleMessageBox(SDL_MessageBoxFlags flags, [NativeTypeName("const char *")] byte* title, [NativeTypeName("const char *")] byte* message, SDL_Window* window);

        [NativeTypeName("#define SDL_MESSAGEBOX_ERROR 0x00000010u")]
        public const uint SDL_MESSAGEBOX_ERROR = 0x00000010U;

        [NativeTypeName("#define SDL_MESSAGEBOX_WARNING 0x00000020u")]
        public const uint SDL_MESSAGEBOX_WARNING = 0x00000020U;

        [NativeTypeName("#define SDL_MESSAGEBOX_INFORMATION 0x00000040u")]
        public const uint SDL_MESSAGEBOX_INFORMATION = 0x00000040U;

        [NativeTypeName("#define SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT 0x00000080u")]
        public const uint SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT = 0x00000080U;

        [NativeTypeName("#define SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT 0x00000100u")]
        public const uint SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT = 0x00000100U;

        [NativeTypeName("#define SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT 0x00000001u")]
        public const uint SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT = 0x00000001U;

        [NativeTypeName("#define SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT 0x00000002u")]
        public const uint SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT = 0x00000002U;
    }
}