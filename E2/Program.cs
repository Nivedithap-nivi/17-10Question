namespace E2
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int[] a = [1,2,3,4,5];
    
            try
            {
                Console.WriteLine(a[6]);

            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End");
        }
    }
}
