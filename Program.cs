namespace conditionals_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a wholn number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            else 
            {
                Console.WriteLine($"{number} is a negitive number");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is a positve number");
            }
            else
            {
                Console.WriteLine($"{number} is a positve number");
            }
        }
    }
}
