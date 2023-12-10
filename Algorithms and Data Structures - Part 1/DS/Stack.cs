using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures___Part_1.DS
{
    public class Stack
    {
        public int MaxSize { get; set; }
        public int Top { get; set; }
        string[] arraystack;
        public Stack(int size)
        {
            MaxSize = size;
            arraystack = new string[size];
            Top = -1;
        }

        public void push(string text)
        {
            Top++;
            arraystack[Top] = text;

        }
        public void pop()
        {
            Top--;
            arraystack = new string[Top];

        }

        public string Peak()
        {
            return arraystack[Top];
        }

        public void clear()
        {
            Top = -1;
            arraystack = new string[Top];
        }

    }
}
