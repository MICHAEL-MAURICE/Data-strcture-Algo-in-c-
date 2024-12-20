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



   



    public void ReverseLinkedList()
    {
        if (head == null || head.Next == null) return;

        Node<T> p1 = null; // Previous node
        Node<T> p2 = head; // Current node
        Node<T> p3 = head.Next; // Next node

        while (p2 != null) // Continue until we reach the end
        {
            p3 = p2.Next; // Store the next node
            p2.Next = p1; // Reverse the current node's pointer

            // Move all pointers one step forward
            p1 = p2;
            p2 = p3;
        }

        head = p1; // Update the head to be the new first node
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

    public void InsertTobeSorted(T item)
    {
        if (item == null) return; // If the item is null, return

        Node<T> newNode = new Node<T>(item);

        // Case 1: The list is empty, set the new node as the head
        if (head == null)
        {
            head = newNode;
            return;
        }

        // Case 2: Insert before the head if the new item is smaller than the head's data
        if (Comparer<T>.Default.Compare(item, head.Data) < 0)
        {
            newNode.Next = head;
            head = newNode;
            return;
        }
        // Case 3: Traverse the list to find the correct insertion point
        Node<T> current = head;
        while (current.Next != null && Comparer<T>.Default.Compare(item, current.Next.Data) > 0)
        {
            current = current.Next; // Move to the next node
        }
        // Insert the new node at the identified position
        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void LeftRoutet()
    {
        if (head == null) { return; }

        Node<T> current = head;
        Node<T> tail = null;
        Node<T> pretail = null;

        while (current != null && current.Next != null)
        {

            if (current.Next.Next == null)
            {
                pretail = current;
                tail = current.Next;
            }

            current = current.Next;
        }
        tail.Next = head;
        head = tail;
        pretail.Next = null;


    }
    public void Swapheadandtail()
    {
        Node<T> current = head;
       
        Node<T> tail = null;
        Node<T> pretail = null;
        if (head == null) { return; }
        while (current != null && current.Next != null)
        {
            if (current.Next.Next == null)
            {
                pretail = current;
                tail = current.Next;

            }

          

            current = current.Next;
        }




        tail.Next = head.Next; // Set tail's next to head's next
        pretail.Next = head;   // Set pretail's next to the original head
        head.Next = null;      // Set original head's next to null
        head = tail;


    }
    public void DeleteEven()
    {
        if (head == null) return; // If the list is empty, return

        Node<T> current = head;
        int count = 1; // Start with 1-based index

        while (current != null && current.Next != null)
        {
            if (count % 2 != 0)
            {
                // Delete the next node
                current.Next = current.Next.Next;
            }
            else
            {
                // Move to the next node
                current = current.Next;
            }
            count++;
        }
    }
}
