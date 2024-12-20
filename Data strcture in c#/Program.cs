// Create a dynamic array of integers
using Data_strcture_in_c_.Daynamic_Array;
using Data_strcture_in_c_.Linked_List;
using Data_strcture_in_c_.Stack;

#region DynamicArray 
//DynamicArray<int> dynamicArray = new DynamicArray<int>();

////// Add elements to the dynamic array
//dynamicArray.Add(10);
//dynamicArray.Add(20);
//dynamicArray.Add(30);
//dynamicArray.Add(40);
////dynamicArray.pop(2);
//dynamicArray.Right_rotation();

//////dynamicArray.left_rotation();
////// Access elements by index
////Console.WriteLine("Element at index 2: " + dynamicArray[2]);

////// Print all elements
////Console.WriteLine("All elements in dynamic array:");
//for (int i = 0; i < dynamicArray.Count; i++)
//{
//    Console.WriteLine(dynamicArray[i]);
//}

//// Remove an element at index 1
//dynamicArray.RemoveAt(1);

//// Print all elements after removal
//Console.WriteLine("After removal:");
//for (int i = 0; i < dynamicArray.Count; i++)
//{
//    Console.WriteLine(dynamicArray[i]);
//}

//// Add more elements to test resizing
//dynamicArray.Add(50);
//dynamicArray.Add(60);

//Console.WriteLine("After adding more elements:");
//for (int i = 0; i < dynamicArray.Count; i++)
//{
//    Console.WriteLine(dynamicArray[i]);
//}

#endregion

#region Linked List
//CusLinkedList<int> intList = new CusLinkedList<int>();
//intList.AddLast(1);
//intList.AddLast(2);
//intList.AddLast(3);
//intList.AddLast(4);
//intList.PrintList();

//intList.PrintList();
//intList.InsertTobeSorted(0);
//intList.LeftRoutet();
////intList.Swapheadandtail();
////intList.DeleteEven();
////intList.ReverseLinkedList();
///*intList.Swap2Nodes()*/;
//intList.PrintList(); // Output: 1 -> 2 -> 3 -> null

//intList.AddFirst(0);
//intList.PrintList(); // Output: 0 -> 1 -> 2 -> 3 -> null

//intList.Delete(2);
//intList.PrintList(); // Output: 0 -> 1 -> 3 -> null

//// Clear the LinkedList manually
//intList.Clear();
//intList.PrintList(); // Output: null

//// Optionally, you can force garbage collection (not recommended in most cases)
//GC.Collect();
//GC.WaitForPendingFinalizers();


#endregion

#region Stack
//MicStack<int>stack=new MicStack<int>();


//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//stack.Push(4);
//stack.Push(5);
//stack.Display();
//stack.Reverse();
//stack.Display();
//stack.Peek();
//stack.Pop();
//stack.IsFull();
//stack.IsEmpty();

//problem 4

MicStack<char> ch = new MicStack<char>();
//ch.validParth('{');
//ch.validParth('(');
//ch.validParth('[');
//ch.Display();
//ch.validParth(']');
//ch.validParth(')');
//ch.validParth('}');
//ch.Display();

//Problem 5
ch.DeleteDuplicate('a');
ch.DeleteDuplicate('b');
ch.DeleteDuplicate('b');
ch.DeleteDuplicate('a');
ch.Display();

#endregion