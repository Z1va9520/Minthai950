namespace Homework_04
{
    class Program
    {
        static void Main(string[] agrs)
        {
            float usa;
            float usatovn;
            float vn = 23000f;
            Console.WriteLine("Enter your money:");
            usa = float.Parse(Console.ReadLine());
            usatovn = usa * vn;
            Console.WriteLine("Vn to UsA: ");
        }       
    }
}