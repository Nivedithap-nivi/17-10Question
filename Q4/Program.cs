namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

           

            int n = list.Count;
            n = (n / 2) + 1;
            //string x = "";
            int c = 0;

            for(LinkedListNode<string> node = list.First;node != null; node = node.Next)
            {
                c++;
                if(c == n)
                {
                    Console.WriteLine(node.Value);
                }
            }
               

        }
    }
}
