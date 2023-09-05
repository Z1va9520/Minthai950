namespace learncode_day6
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            int menu;
            //float DoF, DoC;
            //double DoFxDoC, DoCxDoF ;
            double DoF;
            double DoC;
            Console.WriteLine("Menu ChuyenDoi tu C sang F va nguoc lai: ");
            Console.WriteLine("1. F sang C");
            Console.WriteLine("2. C sang F");
            Console.WriteLine("3. Exit");
            menu = Int32.Parse(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    Console.WriteLine("Nhap so do F: ");
                    DoF = Convert.ToDouble(Console.ReadLine());
                    Console.Write("nhiet do C la: " + chuyendoiC(DoF));
                    break;
                case 2:
                    Console.WriteLine("Nhap so do C: ");
                    DoC = Convert.ToDouble(Console.ReadLine());
                    Console.Write("nhiet do C la: " + chuyendoiC(DoC));
                    break;
                    
                case 3:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Roy");
                    break;
            }

        }


        public static double chuyendoiF(double DoC)
        {
            //double DoC = (DoF - 32) / 1.8f;
            //float chuyendoiC = (DoF - 32) / 1.8f;
            return (DoC - 32) / 1.8f;
        }

        public static double chuyendoiC(double DoF)
        {
            //double DoFxDoC = (DoF - 32) / 1.8f;
            //float chuyendoiC = (DoF - 32) / 1.8f;
            return (DoF - 32) / 1.8f;
        }

    }
}
