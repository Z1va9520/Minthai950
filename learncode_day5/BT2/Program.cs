
namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang_so = { 11, 22, 63, 71, 13 };

            int so_cao_nhat = int.MinValue;

            bool cosolehayko = false;

            for (int i = 0; i < mang_so.Length; i++)
            {
                if (mang_so[i] % 2 == 1)
                {
                    cosolehayko = true;

                    if (mang_so[i] > so_cao_nhat)
                    {
                        so_cao_nhat = mang_so[i];
                    }
                }
            }
            if (!cosolehayko) 
            {
                Console.WriteLine("Trong mang ko co so le");
            }
            else
            {
                Console.WriteLine("so le lon nhat la: " + so_cao_nhat);
            }
        }
    }
}