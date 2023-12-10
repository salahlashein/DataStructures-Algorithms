
using program;
using System.Buffers;
using System.Xml;

namespace AlgorithmsAndDataStructures
{
    public class program
    {



        public static void Main(string[] args)
        {
            // create nodes
            Node nodeA = new Node(_data: "11");
            Node nodeB = new Node(_data: "222");
            Node nodeC = new Node(_data: "333");
            Node nodeD = new Node(_data: "444");

            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            nodeC.Next = nodeD;
            nodeD.Next = null;


            Stack<Node> stack = new Stack<Node>();


            Queue<Node> queue = new Queue<Node>();  




                LinkedList<string> list = new LinkedList<string>();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, };
            int SearchValue = Int32.Parse(Console.ReadLine());
            int results = ALgorithms.BinarySearchAlgo(array, SearchValue);
             Console.WriteLine(results);

        }

    }
}