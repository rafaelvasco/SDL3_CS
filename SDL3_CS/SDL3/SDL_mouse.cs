﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace SDL
{
    [Typedef]
    public enum SDL_MouseID : UInt32;

    public enum SDLButton
    {
        SDL_BUTTON_LEFT = SDL3.SDL_BUTTON_LEFT,
        SDL_BUTTON_MIDDLE = SDL3.SDL_BUTTON_MIDDLE,
        SDL_BUTTON_RIGHT = SDL3.SDL_BUTTON_RIGHT,
        SDL_BUTTON_X1 = SDL3.SDL_BUTTON_X1,
        SDL_BUTTON_X2 = SDL3.SDL_BUTTON_X2,
    }

    [Flags]
    [Typedef]
    public enum SDL_MouseButtonFlags : uint
    {
        SDL_BUTTON_LMASK = SDL3.SDL_BUTTON_LMASK,
        SDL_BUTTON_MMASK = SDL3.SDL_BUTTON_MMASK,
        SDL_BUTTON_RMASK = SDL3.SDL_BUTTON_RMASK,
        SDL_BUTTON_X1MASK = SDL3.SDL_BUTTON_X1MASK,
        SDL_BUTTON_X2MASK = SDL3.SDL_BUTTON_X2MASK,
    }

    public static partial class SDL3
    {
        [Macro]
        public static SDL_MouseButtonFlags SDL_BUTTON(SDLButton button) => (SDL_MouseButtonFlags)(1 << ((int)button - 1));

        public static unsafe SDLArray<SDL_MouseID>? SDL_GetMice()
        {
            int count;
            var array = SDL_GetMice(&count);
            return SDLArray.Create(array, count);
        }
    }
}
