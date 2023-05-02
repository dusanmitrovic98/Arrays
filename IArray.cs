using System.Collections;

namespace DataStructures.Collections.Array;

public interface IArray<T>
{
    public int Length { get; }
    public T this[int index] { get; set; }
    public bool Contains(T value);
}