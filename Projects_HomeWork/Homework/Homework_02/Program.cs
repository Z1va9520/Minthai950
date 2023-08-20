namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            float aren;
            Console.WriteLine("Enter Width: ");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            height = float.Parse(Console.ReadLine());
            aren = width * height;
            Console.Write("Aren is: " + aren);

        }
    }
}