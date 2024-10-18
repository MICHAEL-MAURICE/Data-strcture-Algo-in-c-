using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strcture_in_c_.Linked_List;

public class LinkedList<T>
{
    private Node<T> head;

    public LinkedList()
    {
        head = null;
    }

    // Method to add a new node at the end
    public void AddLast(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // Method to display the LinkedList
    public void PrintList()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    // Method to add a new node at the beginning
    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.Next = head;
        head = newNode;
    }

    // Method to delete a node by value
    public void Delete(T data)
    {
        if (head == null) return;

        // If the head node itself holds the value
        if (EqualityComparer<T>.Default.Equals(head.Data, data))
        {
            head = head.Next;
            return;
        }

        // Search for the node to be deleted
        Node<T> current = head;
        while (current.Next != null && !EqualityComparer<T>.Default.Equals(current.Next.Data, data))
        {
            current = current.Next;
        }

        // If the value was found, skip the node
        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }
}
