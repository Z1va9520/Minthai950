namespace learncode
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int a;
            Console.WriteLine("Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.Write(isPrime);

        }

    }
}