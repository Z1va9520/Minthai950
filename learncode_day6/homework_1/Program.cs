namespace learncode_day6
{
    class Program
    {
         public static int sum(int i1, int i2) {
            int result = 0;
            for (int i = i1; i <= i2; i++)
               result += i;
            return result;
         }

         public static void Main(String[] args) {
            Console.WriteLine("Sum from 1 to 10 is " + sum(1, 10));
            Console.WriteLine("Sum from 20 to 37 is " + sum(20, 37));
            Console.WriteLine("Sum from 35 to 49 is " + sum(35, 49));
         }
    }
}
