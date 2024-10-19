using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strcture_in_c_.Linked_List
{
    public class MyLinkedList<T>
    {
        public Node<T>head { get; set; }
        public MyLinkedList()
        {
            head = null;
        }

        public void AddLast(T item)
        {
            Node<T> newNode= new Node<T>(item);

            if(head==null)head = newNode;
            else
            {
                Node <T>current= head;
                while (current.Next!=null)
                {
                    current= current.Next;

                }
                current.Next = newNode;
            }
        }
        public void AddFirst(T item)
        {
            Node<T>newNode= new Node<T>(item);
            newNode.Next = head;
            head = newNode;
        }

        public void Delete(T item)
        {
            if(head==null) return;
            if (EqualityComparer<T>.Default.Equals(head.Data, item))
            {
                head=head.Next;
                return;
            }
            else
            {
                Node<T> current= head;
                while (current.Next!=null && !EqualityComparer<T>.Default.Equals(current.Next.Data,item)) { 
                
                current= current.Next;
                }
                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                }

            }

        }
          

        public void DeleteFront()
        {
            head = head.Next;
            return;
        }



        public T? GetNthFromBack(int num)
        {
            if (head == null || num < 1)
            {
                // Return null if the list is empty or if the number is invalid
                return default;
            }

            // Step 1: Find the length of the linked list
            int length = 0;
            Node<T> current = head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }

            // Step 2: Calculate the position from the beginning
            int targetIndex = length - num;
            if (targetIndex < 0)
            {
                // If the target index is negative, num is greater than the length of the list
                return default;
            }

            // Step 3: Traverse to the target node
            current = head;
            for (int i = 0; i < targetIndex; i++)
            {
                current = current.Next;
            }

            // Return the data of the target node
            return current.Data;
        }


        public bool IsSame(MyLinkedList<T> other)
        {

            if (head == null && other.head == null)
            {
                return true;
            }
            if (head == null || other.head == null)
            {
                return false;
            }
            Node<T>current= head;
            Node<T> current2 = other.head;

            while (current!= null && current2!=null ) {
                if (!EqualityComparer<T>.Default.Equals(current.Data,current2.Data))
                {
                    return false;
                }
                else
                {
                    current = current.Next;
                    current2 = current2.Next;
                    
                }
            
            }
            return  current == null && current2 == null;
        }


        public void DeleteKey(T key)
        {
            if(head == null) { return; }
          
            if (EqualityComparer<T>.Default.Equals(head.Data,key))
            {
                head=head.Next;
                return;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {

                    if (EqualityComparer<T>.Default.Equals(current.Next.Data, key))
                    {
                        current.Next = current.Next.Next;
                    }
                    else { 
                    current = current.Next;
                        }
                }
                



            }
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
}
