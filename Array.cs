﻿namespace DataStructures.Collections.Array;

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

    public void SetValue(T value, int index)
    {
        throw new NotImplementedException();
    }

    public T GetValue(int index)
    {
        throw new NotImplementedException();
    }
}
