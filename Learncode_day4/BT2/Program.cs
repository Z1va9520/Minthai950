namespace learncode
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int i, j, choice;

            Console.Write("Menu");
            Console.Write("1.Print the rectangle");
            Console.Write("2.Print the square triangle");
            Console.Write("3.Print isosceles triangle");
            Console.Write("4.Exit");

            Console.WriteLine("Choice your number: ");
            choice = Int32.Parse(Console.ReadLine());


            if (choice == 2) 
            {
                for (i = 0; i <= 5; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }

            }

            else if (choice == 3) 
            {
                for (i = 0; i <= 5; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-------------");

                for (i = 5; i >= 1; i--)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }

            else if (choice == 4)
            {
                Console.WriteLine("Exit");
            }

            else if (choice == 1)
            {
                for (i = 0; i <= 3; i++)
                {
                    for (j = 0; j < 8; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
            }
            Console.ReadLine();
        }

    }
}