using program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures___Part_1.DS
{
    public class Queue
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int count { get; set; }

        public Queue(string item)
        {
            Head = Tail = new Node(item);
            count = 1;
        }

        public void Enqueue(Node node)
        {
            if (Tail == null)
            {
                Head = Tail = node;
            }
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
                node.Next = null;
            }
            count++;
        }
        public void Dequeue()
        {
            Head.Next = Head.Next.Next;
            Head.Next.Previous = Head;
            count--;

        }

        public Node Peek() { return Head; }
        public void Clear() { Head = Tail = null; }

    }
}
