namespace Homework_01
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Giai phuong trinh bac 2: ax2 + bx + c = 0");
            Console.WriteLine("Enter number a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c: ");
            float c = float.Parse(Console.ReadLine());
            double delta = Math.Pow(b, 2) - (4 * a * c);
            //Console.WriteLine("Kiem tra Phuong trinh bac may");

            if (a == 0)
            {
                Console.WriteLine("Phuong trinh bac nhat");

            }
            else if (a != 0)
            {
                Console.WriteLine("Phuong trinh bac hai");

            }

            if ( a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine(" Phuong trinh vo so nghiem");
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine(" Phuong trinh vo nghiem");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine($"Phuong trinh 1 nghiem {-c / (2 * b)}");
            }



            if (a != 0 && delta < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            
            else if (a != 0 && delta > 0)

            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet;");
                Console.WriteLine($"X1: {(-b + (Math.Sqrt(delta))) / (2 * a)} ");
                Console.WriteLine($"X2: {(-b - (Math.Sqrt(delta))) / (2 * a)} ");
            }
            else if (a != 0 && delta == 0)
            {

                Console.WriteLine($"Pt co nghiem kep: {-b / (a * 2)}");

            }

            Console.ReadKey();
        }
    }
}