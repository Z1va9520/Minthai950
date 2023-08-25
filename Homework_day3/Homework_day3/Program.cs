
namespace Homework_01
{
    class Program
    {
        static void Main()
        {
            float a;
            float b;
            double solution;
            Console.WriteLine("Enter number a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            b = float.Parse(Console.ReadLine());

            // a = convert.ToInt32(Console.ReadLine());



            if (a != 0)
            {
                //double solution = -b / a;//
                Console.WriteLine($"Pt co 1 nghiem {-b / (a * 2)}");
            }
            //Console.Write("1 nghiem duy nhat:");
            else if (a == 0 && b == 0)
            {
                Console.Write("vo so nghiem");
            }
            else if (a == 0 && b != 0)
            {
                Console.Write("vo nghiem");
            }
            Console.ReadKey();
        }
    }
}