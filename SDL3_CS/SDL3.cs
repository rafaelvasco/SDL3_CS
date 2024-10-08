using System.Runtime.InteropServices;

namespace SDL;

public static unsafe partial class SDL3
{
    /// <summary>
    /// Allocates a managed <c>string</c> and copies all characters up to the first null character from an unmanaged UTF-8 string into it.
    /// </summary>
    /// <param name="ptr">The address of the first character of the unmanaged string.</param>
    /// <param name="free">Whether to free the pointer after copying the string.</param>
    /// <returns>
    /// A managed string that holds a copy of the unmanaged string if the value of the <paramref name="ptr"/> parameter is not <c>null</c>; otherwise, this method returns <c>null</c>.
    /// </returns>
    public static string? PtrToStringUTF8(byte* ptr, bool free = false)
    {
        string? s = Marshal.PtrToStringUTF8((IntPtr)ptr);

        if (free)
            SDL_free(ptr);

        return s;
    }
}