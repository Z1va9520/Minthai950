
namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang_so = { 10, 44, 62, 71, 13 };

            int so_cao_nhat = int.MinValue;

            for (int i = 0; i < mang_so.Length; i++) 
            {
                if (so_cao_nhat < mang_so[i])
                {
                    so_cao_nhat = mang_so[i];

                }
            }
            Console.WriteLine("So cao nhat la" + so_cao_nhat);

        }
    }
}