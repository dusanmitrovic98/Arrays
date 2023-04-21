namespace DataStructures.Collections.Array;

public interface IArray<T>
{
    public int Length { get; }
    public T this[int index] { get; set; }
    public bool Contains(T value);
    public void SetValue(T value, int index);
    public T GetValue(int index);
    public void ValidateIndex(int index);
    public void CopyTo(ref Array<T> array, int index = default);
}