public interface IArray<T>
{
    public int Length { get; }
    public T this[int index] { get; set; }
}