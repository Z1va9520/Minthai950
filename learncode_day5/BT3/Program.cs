
namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mang = new int[100, 100];
            int dong;
            int cot;
            int so_cao_nhat = int.MinValue;
            int so_nho_nhat = int.MaxValue;
            Console.Write("Nhap so cot muon hien thi: ");
            cot = int.Parse(Console.ReadLine());

            Console.Write("Nhap so dong muon hien thi: ");
            dong = int.Parse(Console.ReadLine());

            for (int x = 0; x < dong; x++)
            {
                for (int y = 0; y < cot; y++)
                {
                    Console.Write("Nhap so cho dong {0}, cot {1} la: ", x+1, y+1);
                    mang[x, y] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ma tran da nhap la:");
            for (int x = 0; x < dong; x++)
            {
                for (int y = 0; y < cot; y++)
                {
                    Console.Write("{0} ", mang[x, y]);
                }
                Console.WriteLine();               
            }


            Console.WriteLine("Tim so lon nhat trong mang:");
            for (int x = 0; x < dong; x++)
            {
                for (int y = 0; y < cot; y++)
                {
                    if (mang[x, y] > so_cao_nhat) 
                    {
                        so_cao_nhat = mang[x, y];
                    }
                }
            }
            Console.WriteLine("So lon nhat trong mang la:{0}", so_cao_nhat);

            Console.WriteLine("Tim so nho nhat trong mang:");
            for (int x = 0; x < dong; x++)
            {
                for (int y = 0; y < cot; y++)
                {
                    if (mang[x, y] < so_nho_nhat)
                    {
                        so_nho_nhat = mang[x, y];
                    }
                }
            }
            Console.WriteLine("So nho nhat trong mang la:{0}", so_nho_nhat);


            Console.ReadLine();

        }
    }
}