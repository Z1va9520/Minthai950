namespace BT1
{
    class program
    {
        static void Main(string[] agrs)
        {
            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("Get Arena: " + rectangle.Getarea());
            Console.WriteLine("Get Preimete: " + rectangle.Getprerimetes());
            Console.WriteLine("Display: " + rectangle.Display());


            Console.ReadLine();
        }

        public class Rectangle
        {
            double width, height; //Khai bien 

            public Rectangle() // tao bien chua
            {
            }

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }


            public double Getarea()
            {
                return this.width * this.height;
            }

            public double Getprerimetes()
            {
                return (this.width + this.height) * 2;
            }

            public string Display()
            {
                return "Width is: " + this.width + " height is: " + this.height;
                //"Rectangle{" + "width=" + width + ", height=" + height + "}";
            }



        }


    }
}