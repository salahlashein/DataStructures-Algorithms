using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using program;

namespace Algorithms_and_Data_Structures___Part_1.DS
{
    public class LinkedList : ICollection<string>
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public bool IsReadOnly { get; }

        public void Add(string item)
        {
            if (Head == null) Head.Next = Tail.Previous = new Node(item);
            else
            {
                Node NewNode = new Node(_data: item);
                NewNode.Next = Head.Next;
                Head.Next = NewNode;
            }
        }


        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(string item)
        {
            Node Findable = Find(item);
            return Findable != null;

        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            Node temp = Head;
            while (temp.Next != null)
            {
                array[arrayIndex] = temp.Data;

                arrayIndex++;
                temp.Next = temp.Next.Next;
            }

        }



        public bool Remove(string item)
        {
            Node temp = Head;

            Node Findable = Find(item);
            if (Findable == null)
            {
                return false;
            }
            else
            {
                while (temp.Next != null)
                {
                    if (item == temp.Data)
                    {
                        temp.Next.Previous = temp.Previous;
                        temp.Previous.Next = temp.Next;
                        Count--;
                    }
                    temp = temp.Next;

                }
            }
            return true;
        }


        public Node Find(string item)
        {
            Node temp = Head;
            while (temp.Next != null)
            {
                if (item == temp.Data)
                {

                    return temp;
                }
                temp = temp.Next;
            }


            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


}
