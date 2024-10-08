﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace SDL
{
    [Typedef]
    public enum SDL_SensorID : UInt32;

    public static partial class SDL3
    {
        public static unsafe SDLArray<SDL_SensorID>? SDL_GetSensors()
        {
            int count;
            var array = SDL_GetSensors(&count);
            return SDLArray.Create(array, count);
        }
    }
}
