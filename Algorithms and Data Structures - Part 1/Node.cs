using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class Node
    {
        LinkedList<Node> children;  
        public string Data { get; set; }
        public Node? Next
        { get; set; }
        public Node? Previous
        { get; set; }


        public void DisplayNode()
        {
            Console.WriteLine("test");
        }
        public Node(string _data)
        {
            Data = _data;   
        }
    }
}
