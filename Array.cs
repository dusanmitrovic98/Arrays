namespace DataStructures.Collections.Array;

public class Array<T> : IArray<T>
{
    /// <summary>
    /// Array elements, where T represents predefined type for each element in the array.
    /// </summary>
    private T[] _elements;

    /// <summary>
    /// Gets the total number of elements in the array.
    /// </summary>
    /// <value></value>
    public int Length
    {
        get { return _elements.Length; }
    }

    public Array(int length)
    {
        this._elements = new T[length];
    }

    /// <summary>
    /// Gets or sets the value at the specific index.
    /// </summary>
    /// <value>Array element at the given index.</value>
    public T this[int index]
    {
        get { return _elements[index]; }
        set { this._elements[index] = value; }
    }

    /// <summary>
    /// Transforms array to the corresponding string form.
    /// </summary>
    /// <returns>String form of the array.</returns>
    public override string ToString()
    {
        var result = "";

        for (int i = 0; i < this.Length; i++)
        {
            if (i == 0)
            {
                result += "[" + this[i] + ", ";
                continue;
            }

            if (i == (this.Length - 1))
            {
                result += this[i] + "]";
                break;
            }

            result += this[i] + ", ";
        }

        return result;
    }

    /// <summary>
    /// Determines whether the array contains a specific value.
    /// </summary>
    /// <param name="value">Targeted value.</param>
    /// <returns>True if array contains the given value, otherwise false.</returns>
    public bool Contains(T value)
    {
        for (int i = 0; i < this.Length; i++)
        {
            if ((this[i]?.Equals(value) ?? false) == true)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Sets the value at the specified index.
    /// </summary>
    /// <param name="value">Value to be set at the specified index.</param>
    /// <param name="index">Index at which value will be set.</param>
    public void SetValue(T value, int index)
    {
        this.ValidateIndex(index);

        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the value of the element at the given index.
    /// </summary>
    /// <param name="index">Index of the targeted element in the array.</param>
    /// <returns>Value of the element in the array at the given index.</returns>
    public T GetValue(int index)
    {
        this.ValidateIndex(index);

        throw new NotImplementedException();
    }

    /// <summary>
    /// Validates if the given index is in the range of the valid array indexes.
    /// </summary>
    /// <param name="index">Targeted index value that will be validated.</param>
    public void ValidateIndex(int index)
    {
        if (index >= 0 && index < this.Length)
        {
            return;
        }

        throw new ArgumentOutOfRangeException("index");
    }

    public void CopyTo(ref Array<T> array, int index = 0)
    {
        ValidateIndex(index);
        var length = this.Length - index;
        array = new Array<T>(length);
        for (int i = index; i < this.Length; i++)
        {
            array[i] = this[i];
        }
    }

    public Array<T> Copy(int index = 0)
    {
        var length = this.Length - index;
        var array = new Array<T>(length);

        for (int i = index; i < this.Length; i++)
        {
            array[i] = this[i];
        }

        return array;
    }
}
