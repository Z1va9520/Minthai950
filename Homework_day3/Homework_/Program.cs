namespace Homework
{
    class Program
    {
        static void Main(string[] agrs)
        {
            float weight;
            float height;
            
            Console.WriteLine("Enter weigh: ");
            weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter heigh: ");
            height = float.Parse(Console.ReadLine());

            double bmi = weight / (Math.Pow(height, 2));
            Console.WriteLine($"Your BMi:{bmi}");


            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else if (bmi > 30)
            {
                Console.WriteLine("Obese");
            }
            Console.ReadKey();
        }
    }
}