using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strcture_in_c_.Daynamic_Array;


public class DynamicArray<T>
{
   
    private T[] _array;    // Underlying array
    private int _count;    // Tracks the number of elements added

    // Constructor to initialize the dynamic array with an initial capacity
    public DynamicArray(int capacity = 4)
    {
        _array = new T[capacity];
        _count = 0;
    }

    // Property to get the number of elements in the array
    public int Count
    {
        get { return _count; }
    }

    // Property to get the current capacity of the array
    public int Capacity
    {
        get { return _array.Length; }
    }

    // Method to add an element to the dynamic array
    public void Add(T item)
    {
        // If the internal array is full, resize it
        if (_count == _array.Length)
        {
            Resize();
        }

        // Add the new item and increment the count
        _array[_count] = item;
        _count++;
    }

    // Method to resize the array when capacity is exceeded
    private void Resize()
    {
        // Double the size of the array
        int newCapacity = _array.Length * 2;
        T[] newArray = new T[newCapacity];

        // Copy the existing elements to the new array
        for (int i = 0; i < _array.Length; i++)
        {
            newArray[i] = _array[i];
        }

        // Replace the old array with the new, larger array
        _array = newArray;
    }

    // Method to retrieve an element at a specific index
    public T Get(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }

        return _array[index];
    }

    // Method to set an element at a specific index
    public void Set(int index, T value)
    {
        if (index < 0 || index >= _count)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }

        _array[index] = value;
    }

    // Method to remove an element by index
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }

        // Shift all elements to the left to fill the gap
        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        // Decrease the count
        _count--;
    }

    // Indexer to allow array-like access
    public T this[int index]
    {
        get => Get(index);   // This is called when accessing the value at the given index
        set => Set(index, value);  // This is called when assigning a value to the given index
    }
}

