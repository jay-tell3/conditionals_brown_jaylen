namespace conditionals_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   //asks for a whole number
            Console.WriteLine("type a whole number");
            //set the answer to int and set it as  the varible
            int number = Convert.ToInt32(Console.ReadLine());
            //check if it is postive or negitve and tells the user
            if (number >= 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            else 
            {
                Console.WriteLine($"{number} is a negitive number");
            }
            //check if it is odd or even and tells the user
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is a even number");
            }
            else
            {
                Console.WriteLine($"{number} is a odd number");
            }    
                //makes two random numbers in a int varble
                int numb1 = 86;
                int numb2 = 78;
                // gets max
                int fristMax = Math.Max( number, numb1 );
                //Gets maximum the number
                int max = Math.Max( fristMax, numb2 );
                // prints max to console
                Console.WriteLine($"the maximum number of {number},{numb1}, and {numb2} is {max}!");
                // ask the user to type A letter
                Console.WriteLine("enter A, B, C, D, or F");
                //gets the answer and makes it a char varible
                char grade = Console.ReadKey().KeyChar;
               // pirints an answer bas3ed on the response
                switch (grade)
                { 
                    case 'A' :
                        Console.WriteLine("\nSuperior");
                        break;
                    case 'B':
                        Console.WriteLine("\nVery Good");
                        break;
                    case 'C':
                        Console.WriteLine("\nAverage");
                        break;
                    case 'D':
                        Console.WriteLine("\nBelow Average");
                        break;
                    case 'F':
                        Console.WriteLine("\nFail");
                        break;
                    default: 
                        Console.WriteLine("\nnot a valed letter" +
                            " enterd");
                        break ;
                

            }
        }
    }
}
