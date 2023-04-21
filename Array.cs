namespace DataStructures.Collections.Array;

public class Array<T>
{
    /// <summary>
    /// Array elements, where T represents predefined type for each element in the array.
    /// </summary>
    private T[] _elements;

    public int Length
    {
        get { return _elements.Length; }
    }
}
