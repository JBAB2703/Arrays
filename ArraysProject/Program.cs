using System;

namespace ArraysProject {
    class Program {

        static void Main(string[] args)
        {
            int[] frames = new int[30];
            frames[0] = 10;
            frames[1] = 25;
            frames[2] = 5;
            frames[3] = 10;
            frames[4] = 15;
            frames[5] = 12;
            frames[6] = 26;
            frames[7] = 2;
            frames[8] = 30;
            frames[9] = 28;

            int total = 0;
            int index = 0;
            while(index < 30)
            {
                total = total + frames[index];
                index = index + 1;
            }
            Console.WriteLine($"Total is {total}");
        }

    }
}
