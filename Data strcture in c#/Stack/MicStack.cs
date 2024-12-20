using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strcture_in_c_.Stack;

public class MicStack<T>
{
    private T[] stackArray;
    private int top;
    private int maxSize;

    // Constructor to initialize stack
    public MicStack()
    {
        maxSize = 2;
        stackArray = new T[maxSize];
        top = -1; // Indicates the stack is empty
    }

    // Push method to add an element to the stack
    public void Push(T item)
    {
        if (IsFull())
        {
            DublicateSize();
            //Console.WriteLine("Stack overflow! Cannot push more elements.");
          
        }
        stackArray[++top] = item;
        Console.WriteLine($"Pushed {item} onto the stack.");
    }

    private void DublicateSize()
    {
        maxSize = maxSize * 2;
        var newarray = new T[maxSize];
        for (int i =0;i<stackArray.Count();i++) {

            newarray[i]= stackArray[i];
        
        }

        stackArray=newarray;



    }





    // Pop method to remove and return the top element of the stack
    public T Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack underflow! No elements to pop.");
            return default; // Return default value to indicate stack is empty
        }
        Console.WriteLine($"Popped {stackArray[top]} from the stack.");
        return stackArray[top--];
    }

    // Peek method to return the top element without removing it
    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty! Nothing to peek.");
            return default;
        }
        return stackArray[top];
    }

    // Method to check if the stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Method to check if the stack is full
    public bool IsFull()
    {
        return top == maxSize - 1;
    }

    // Method to display the elements in the stack
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return;
        }
        Console.WriteLine("Stack elements:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stackArray[i]);
        }
    }


    public void Reverse()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty! Cannot reverse.");
            return;
        }

        T[] tempArray = new T[maxSize];
        int tempTop = 0;

        while (!IsEmpty())
        {
            tempArray[tempTop++] = Pop();
        }

        stackArray = tempArray;
        top = tempTop - 1;

        Console.WriteLine("Stack has been reversed.");
    }


    public void validParth(T c)
    {


        if (!IsEmpty()) {

            if ((Peek().Equals('{') && c.Equals('}')) || (Peek().Equals('(') && c.Equals(')')) || (Peek().Equals('[') && c.Equals(']')))
            {
                Pop();

            }
            else { 
            
            Push(c);
            
            }
        
 
        }
        else
        {
            Push(c);
        }

    }



    public void DeleteDuplicate(T c)
    {
        if (!IsEmpty())
        {
            if ((Peek().Equals(c)) || (Peek().Equals(c)) || (Peek().Equals(c)))
            {
                Pop();

            }
            else
            {

                Push(c);

            }


        }
        else
        {
            Push(c);
        }
    }

}