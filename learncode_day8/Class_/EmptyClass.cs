using System;
namespace Class_Anim
{
    public abstract class Animal
    {
        protected string Weidth { get; set; }
        protected string Height { get; set; }


        public Animal(string weidth, string height)
        {
            this.Weidth = weidth; // W la thuoc tinh cuar Animal gan cho w 
            this.Height = height;
        }

        public abstract void PrintInfo();
    }

    class Cat : Animal
    {
        private string Name { get; set; } //  khoi tao Name trong class cat

        public Cat(string weidth, string height, string name)
            : base(weidth, height) // goi thuoc tinh tu nhom animal gan vao cat
        {
            this.Name = name;
        }

        public override void PrintInfo() // in ra cac thuoc tinh tu lop animal
        {
            Console.Write(" Weidth is:{0}. Height is:{1}. Name {2}", this.Weidth, this.Height, this.Name);
        }
    }




}

