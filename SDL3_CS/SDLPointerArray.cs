using System.Diagnostics;

namespace SDL;

public sealed unsafe class SDLPointerArray<T> : IDisposable
    where T : unmanaged
{
    private readonly T** array;
    public readonly int Count;
    private bool isDisposed;

    internal SDLPointerArray(T** array, int count)
    {
        this.array = array;
        Count = count;
    }

    public T this[int index]
    {
        get
        {
            ObjectDisposedException.ThrowIf(isDisposed, this);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, Count);
            Debug.Assert(array[index] != null);
            return *array[index];
        }
    }

    public void Dispose()
    {
        if (isDisposed)
            return;

        isDisposed = true;

        SDL3.SDL_free(array);
    }
}