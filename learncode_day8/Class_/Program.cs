﻿using Class_Anim;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5", "kitty");
            cat.PrintInfo();

            Console.ReadLine();
        }
    }
}