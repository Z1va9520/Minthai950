namespace MyNamespace
{
    class Program
    {
        static void Main(string[] agrs)
        {
            double number;
            Console.WriteLine("Enter number: ");
            //number = Int32.Parse(Console.ReadLine());
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"number:{number}");

            switch (number)
            {
                case 1:
                    Console.WriteLine("one");
                     break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                 case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("serven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
               
            }

            switch (number)
            {
                case 20:
                    Console.WriteLine("Twenty");
                    break;
                case 30:
                    Console.WriteLine("thirty");
                    break;
                case 40:
                    Console.WriteLine("forty");
                    break;
                case 50:
                    Console.WriteLine("fifty");
                    break;
                case 60:
                    Console.WriteLine("sixty");
                    break;
                case 70:
                    Console.WriteLine("seventy");
                    break;
                case 80:
                    Console.WriteLine("eighty");
                    break;
                case 90:
                    Console.WriteLine("ninety");
                    break;
            }
            Console.Write($"Your number text {number}");
            Console.ReadLine();
        }
    }
}