namespace Q2
{
    public class Program
    {
        static void Main(string[] args)
        {
         LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            for (LinkedListNode<string> node = list.Last; node != null; node = node.Previous)
            {
                Console.WriteLine(node.Value);
            }

        }
    }
}
