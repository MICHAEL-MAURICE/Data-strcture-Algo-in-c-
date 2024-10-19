using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strcture_in_c_.Linked_List;

public class CusLinkedList<T>
{
    private Node<T> head;

    public CusLinkedList()
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


    ~CusLinkedList()
    {
        Clear();
    }

    // Method to clear the LinkedList
    public void Clear()
    {
        Node<T> current = head;
        while (current != null)
        {
            Node<T> temp = current;
            current = current.Next;
            temp.Next = null; // Break the link to the next node
        }
        head = null; // Set the head to null
    }


    public void Swap2Nodes()
    {
        if (head == null || head.Next == null) return; // If the list is empty or has only one node, return.

        Node<T> current = head;
        head = current.Next; // Update the head to the second node, as it will become the new head after the swap.

        while (current != null && current.Next != null)
        {
            Node<T> first = current;
            Node<T> second = current.Next;

            // Swapping the two nodes
            first.Next = second.Next;
            second.Next = first;

            // Move the current pointer two nodes ahead
            if (first.Next != null && first.Next.Next != null)
            {
                current = first.Next;
                first.Next = current.Next;
            }
            else
            {
                current = first.Next;
            }
        }
    }
}
