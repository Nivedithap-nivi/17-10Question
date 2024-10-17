namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Queue<string> queue = new Queue<string>(list);
            
        }
    }
}
