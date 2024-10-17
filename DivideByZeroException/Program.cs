namespace DivideByZeroExceptioneEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numerator: "); 
            int numerator=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Denominator:");
            int denominator=int.Parse(Console.ReadLine());

            try
            {
                int result = numerator / denominator;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
