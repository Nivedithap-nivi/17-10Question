using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddLast(3);
            list1.AddLast(1);
            list1.AddLast(2);

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(5);
            list2.AddLast(4);
            list2.AddLast(6);

            LinkedList<int> l1 = new LinkedList<int>(list1.OrderByDescending(x => x));

            foreach (int i in l1)
            {
                Console.WriteLine(i);
            }

            LinkedList<int> l2 = new LinkedList<int>(list2.OrderByDescending(x => x));
            foreach (int i in l2)
            {
                Console.WriteLine(i);
            }

            LinkedList<int> l3 = new LinkedList<int>();
            foreach (int i in l2)
            {
                l3.AddLast(i);
            }

            foreach (int i in l1)
            {
                l3.AddLast(i);
            }

            foreach (int i in l3)
            {
                Console.WriteLine(i);
            }
            
           
    
            

        }
    }
}
