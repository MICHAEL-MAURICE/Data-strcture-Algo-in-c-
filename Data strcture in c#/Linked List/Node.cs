using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_strcture_in_c_.Linked_List
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T>Next { get; set; }

        public Node(T data)
        {
            data = data;
            Next = null;
        }
    }
}
