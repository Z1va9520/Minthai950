namespace learncode_day6
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            int j = 7;
            int i = 3;
            int k = Max(j, i);
            Console.WriteLine($"the maxium {j} and {i} is {k}");
        }

        public static int Max(int i1, int i2)
        {
            int resule;
            if (i1 > i2)
            {
                resule = i1;
            }
            else if (i1 < i2)
            {
                resule = i2;
            }
            else
            {
                resule = i1;
            }

            return resule;
        }

    }
}
