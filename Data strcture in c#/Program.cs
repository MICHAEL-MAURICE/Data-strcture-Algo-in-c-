// Create a dynamic array of integers
using Data_strcture_in_c_.Daynamic_Array;

#region DynamicArray 
DynamicArray<int> dynamicArray = new DynamicArray<int>();

// Add elements to the dynamic array
dynamicArray.Add(10);
dynamicArray.Add(20);
dynamicArray.Add(30);
dynamicArray.Add(40);
dynamicArray.pop(2);
//dynamicArray.Right_rotation(2);

//dynamicArray.left_rotation();
// Access elements by index
Console.WriteLine("Element at index 2: " + dynamicArray[2]);

// Print all elements
Console.WriteLine("All elements in dynamic array:");
for (int i = 0; i < dynamicArray.Count; i++)
{
    Console.WriteLine(dynamicArray[i]);
}

// Remove an element at index 1
dynamicArray.RemoveAt(1);

// Print all elements after removal
Console.WriteLine("After removal:");
for (int i = 0; i < dynamicArray.Count; i++)
{
    Console.WriteLine(dynamicArray[i]);
}

// Add more elements to test resizing
dynamicArray.Add(50);
dynamicArray.Add(60);

Console.WriteLine("After adding more elements:");
for (int i = 0; i < dynamicArray.Count; i++)
{
    Console.WriteLine(dynamicArray[i]);
}

#endregion

