using System.Threading;


namespace game_snake
{
    class snake
    {
        int Height = 20;
        int Width = 30;

        int[] X = new int[50];
        int[] Y = new int[50];

        int fruitX;
        int fruitY;


        int parts = 3;

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'W';

        Random rnd = new Random();

        snake()
        {
            X[0] = 5;
            Y[0] = 5;
            Console.CursorVisible = false;
            fruitX = rnd.Next(2, (Width - 2));
            fruitY = rnd.Next(2, (Height - 2));
        }


        //Tao map 
        public void WriteBroad()
        {
            Console.Clear();
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }

            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, (Height + 2));
                Console.Write("-");
            }

            for (int i = 1; i <= (Height + 2); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }

            for (int i = 1; i <= (Height + 2); i++)
            {
                Console.SetCursorPosition((Width + 2), i);
                Console.Write("|");
            }

            Console.SetCursorPosition(2, 40);

        }
        
        // Nguoi nhap phim di chuyen
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }


        // tinh diem 
        public void WritePoin(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('#');
        }


        public void logic()
        {
            if (X[0] == fruitX)
            {
                if (Y[0] == fruitY)
                {
                    parts++;
                    fruitX = rnd.Next(2, (Width - 2));
                    fruitY = rnd.Next(2, (Height - 2));

                }
            }
            for (int i = parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];

                Y[i - 1] = Y[i - 2];

            }
            // phim di chuyen
            switch(key)
            {
                case 'W':
                    Y[0]--;
                    break;
                case 'S':
                    Y[0]++;
                    break;
                case 'D':
                    X[0]++;
                    break;
                case 'A':
                    X[0]--;
                    break;
            }

            for (int i = 0; i <= (parts - 1); i++)
            {
                WritePoin(X[i], Y[i]);
                WritePoin(fruitX, fruitY);
            }
            Thread.Sleep(500);
        }
        
        
        static void Main(string [] agrs)
        {
            snake Snake = new snake();
            while (true) 
            { 
                  Snake.WriteBroad();
                  Snake.Input();
                  Snake.logic();
                  //Console.ReadKey();
            }
            Console.ReadKey();
        }
        
    }
}