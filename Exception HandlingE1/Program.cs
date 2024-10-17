namespace Exception_HandlingE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of A: ");
            int A=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of B: ");
            int B=int.Parse(Console.ReadLine());

            try
            {
                int ans = A / B;
                Console.WriteLine(ans);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            Console.WriteLine("End");
        }
    }
}
