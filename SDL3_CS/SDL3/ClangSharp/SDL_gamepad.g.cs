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

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    public partial struct SDL_Gamepad
    {
    }

    public enum SDL_GamepadType
    {
        SDL_GAMEPAD_TYPE_UNKNOWN = 0,
        SDL_GAMEPAD_TYPE_STANDARD,
        SDL_GAMEPAD_TYPE_XBOX360,
        SDL_GAMEPAD_TYPE_XBOXONE,
        SDL_GAMEPAD_TYPE_PS3,
        SDL_GAMEPAD_TYPE_PS4,
        SDL_GAMEPAD_TYPE_PS5,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_PRO,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_LEFT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_PAIR,
        SDL_GAMEPAD_TYPE_MAX,
    }

    public enum SDL_GamepadButton
    {
        SDL_GAMEPAD_BUTTON_INVALID = -1,
        SDL_GAMEPAD_BUTTON_SOUTH,
        SDL_GAMEPAD_BUTTON_EAST,
        SDL_GAMEPAD_BUTTON_WEST,
        SDL_GAMEPAD_BUTTON_NORTH,
        SDL_GAMEPAD_BUTTON_BACK,
        SDL_GAMEPAD_BUTTON_GUIDE,
        SDL_GAMEPAD_BUTTON_START,
        SDL_GAMEPAD_BUTTON_LEFT_STICK,
        SDL_GAMEPAD_BUTTON_RIGHT_STICK,
        SDL_GAMEPAD_BUTTON_LEFT_SHOULDER,
        SDL_GAMEPAD_BUTTON_RIGHT_SHOULDER,
        SDL_GAMEPAD_BUTTON_DPAD_UP,
        SDL_GAMEPAD_BUTTON_DPAD_DOWN,
        SDL_GAMEPAD_BUTTON_DPAD_LEFT,
        SDL_GAMEPAD_BUTTON_DPAD_RIGHT,
        SDL_GAMEPAD_BUTTON_MISC1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE1,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE2,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE2,
        SDL_GAMEPAD_BUTTON_TOUCHPAD,
        SDL_GAMEPAD_BUTTON_MISC2,
        SDL_GAMEPAD_BUTTON_MISC3,
        SDL_GAMEPAD_BUTTON_MISC4,
        SDL_GAMEPAD_BUTTON_MISC5,
        SDL_GAMEPAD_BUTTON_MISC6,
        SDL_GAMEPAD_BUTTON_MAX,
    }

    public enum SDL_GamepadButtonLabel
    {
        SDL_GAMEPAD_BUTTON_LABEL_UNKNOWN,
        SDL_GAMEPAD_BUTTON_LABEL_A,
        SDL_GAMEPAD_BUTTON_LABEL_B,
        SDL_GAMEPAD_BUTTON_LABEL_X,
        SDL_GAMEPAD_BUTTON_LABEL_Y,
        SDL_GAMEPAD_BUTTON_LABEL_CROSS,
        SDL_GAMEPAD_BUTTON_LABEL_CIRCLE,
        SDL_GAMEPAD_BUTTON_LABEL_SQUARE,
        SDL_GAMEPAD_BUTTON_LABEL_TRIANGLE,
    }

    public enum SDL_GamepadAxis
    {
        SDL_GAMEPAD_AXIS_INVALID = -1,
        SDL_GAMEPAD_AXIS_LEFTX,
        SDL_GAMEPAD_AXIS_LEFTY,
        SDL_GAMEPAD_AXIS_RIGHTX,
        SDL_GAMEPAD_AXIS_RIGHTY,
        SDL_GAMEPAD_AXIS_LEFT_TRIGGER,
        SDL_GAMEPAD_AXIS_RIGHT_TRIGGER,
        SDL_GAMEPAD_AXIS_MAX,
    }

    public enum SDL_GamepadBindingType
    {
        SDL_GAMEPAD_BINDTYPE_NONE = 0,
        SDL_GAMEPAD_BINDTYPE_BUTTON,
        SDL_GAMEPAD_BINDTYPE_AXIS,
        SDL_GAMEPAD_BINDTYPE_HAT,
    }

    public partial struct SDL_GamepadBinding
    {
        public SDL_GamepadBindingType input_type;

        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L245_C5")]
        public _input_e__Union input;

        public SDL_GamepadBindingType output_type;

        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L265_C5")]
        public _output_e__Union output;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _input_e__Union
        {
            [FieldOffset(0)]
            public int button;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L249_C9")]
            public _axis_e__Struct axis;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L256_C9")]
            public _hat_e__Struct hat;

            public partial struct _axis_e__Struct
            {
                public int axis;

                public int axis_min;

                public int axis_max;
            }

            public partial struct _hat_e__Struct
            {
                public int hat;

                public int hat_mask;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _output_e__Union
        {
            [FieldOffset(0)]
            public SDL_GamepadButton button;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L269_C9")]
            public _axis_e__Struct axis;

            public partial struct _axis_e__Struct
            {
                public SDL_GamepadAxis axis;

                public int axis_min;

                public int axis_max;
            }
        }
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMapping([NativeTypeName("const char *")] byte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMappingsFromIO(SDL_IOStream* src, SDL_bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMappingsFromFile([NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ReloadGamepadMappings();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern byte** SDL_GetGamepadMappings(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForGUID", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* Unsafe_SDL_GetGamepadMappingForGUID(SDL_GUID guid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMapping", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* Unsafe_SDL_GetGamepadMapping(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetGamepadMapping(SDL_JoystickID instance_id, [NativeTypeName("const char *")] byte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasGamepad();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickID* SDL_GetGamepads(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsGamepad(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadNameForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPathForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadPathForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadPlayerIndexForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GUID SDL_GetGamepadGUIDForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadVendorForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProductForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProductVersionForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadTypeForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetRealGamepadTypeForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForID", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* Unsafe_SDL_GetGamepadMappingForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_OpenGamepad(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_GetGamepadFromID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_GetGamepadFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PropertiesID SDL_GetGamepadProperties(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickID SDL_GetGamepadID(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadName(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPath", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadPath(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetRealGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadVendor(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProduct(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProductVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSerial", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadSerial(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetGamepadSteamHandle(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickConnectionState SDL_GetGamepadConnectionState(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PowerState SDL_GetGamepadPowerInfo(SDL_Gamepad* gamepad, int* percent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GamepadConnected(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_GetGamepadJoystick(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGamepadEventsEnabled(SDL_bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GamepadEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadBinding** SDL_GetGamepadBindings(SDL_Gamepad* gamepad, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UpdateGamepads();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadTypeFromString([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForType", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadStringForType(SDL_GamepadType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadAxis SDL_GetGamepadAxisFromString([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForAxis", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadStringForAxis(SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        public static extern short SDL_GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButton SDL_GetGamepadButtonFromString([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForButton", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadStringForButton(SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte SDL_GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButtonLabel SDL_GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButtonLabel SDL_GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, [NativeTypeName("Uint8 *")] byte* state, float* x, float* y, float* pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, SDL_bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RumbleGamepad(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RumbleGamepadTriggers(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetGamepadLED(SDL_Gamepad* gamepad, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SendGamepadEffect(SDL_Gamepad* gamepad, [NativeTypeName("const void *")] IntPtr data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseGamepad(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN => "SDL.joystick.cap.mono_led"u8;

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN => "SDL.joystick.cap.rgb_led"u8;

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN => "SDL.joystick.cap.player_led"u8;

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN => "SDL.joystick.cap.rumble"u8;

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN => "SDL.joystick.cap.trigger_rumble"u8;
    }
}