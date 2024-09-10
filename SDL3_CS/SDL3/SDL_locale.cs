// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace SDL
{
    public static partial class SDL3
    {
        public static unsafe SDLPointerArray<SDL_Locale>? SDL_GetPreferredLocales()
        {
            int count;
            var array = SDL_GetPreferredLocales(&count);
            return SDLArray.Create(array, count);
        }
    }
}
