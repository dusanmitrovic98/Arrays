# Arrays

C# Library with implemented Arrays functionalities.

public int Length { get; } - Gets the total number of elements in the array.
public int Rank { get; } - Gets the rank (dimensionality) of the array.
public void SetValue(object value, int index) - Sets the value of the element at the specified index in the array.
public object GetValue(int index) - Gets the value of the element at the specified index in the array.
public void CopyTo(Array array, int index) - Copies the elements of the array to the specified array starting at the specified destination index.
public object Clone() - Creates a shallow copy of the array.
public IEnumerator GetEnumerator() - Returns an enumerator that iterates through the array.
public static Array CreateInstance(Type elementType, int length) - Creates a new array of the specified element type and length.
public static Array CreateInstance(Type elementType, params int[] lengths) - Creates a new multidimensional array of the specified element type and dimensions.
public static int BinarySearch(Array array, object value) - Searches for the specified object in a sorted one-dimensional array.
public static void Clear(Array array, int index, int length) - Sets a range of elements in the array to the default value for the element type.
public static bool Exists(Array array, Predicate<object> match) - Determines whether the specified predicate returns true for any element in the array.
public static void Fill(Array array, object value) - Sets all the elements in the array to the specified value.
public static void Reverse(Array array) - Reverses the order of the elements in the array.
public static void Sort(Array array) - Sorts the elements in the array.
public static void Sort(Array array, IComparer comparer) - Sorts the elements in the array using the specified comparer.
public static void Sort(Array array, Comparison<object> comparison) - Sorts the elements in the array using the specified comparison function.
public static void Sort(Array array, int index, int length) - Sorts a range of elements in the array.
public static void Sort(Array array, int index, int length, IComparer comparer) - Sorts a range of elements in the array using the specified comparer.
public static void Sort(Array array, int index, int length, Comparison<object> comparison) - Sorts a range of elements in the array using the specified comparison function.
