using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int nr = 0;
            for (int i =99; i>=0; i--) {
                Console.WriteLine($"{i} bottles of bear on wall"+"\n"+ " Take one down and pass it around "+ $"{i}"+ " bottles of beer on the wall ");
               if (i ==0) {
                    Console.WriteLine ("No more bottles of beer on the wall, no more bottles of beer."+ "\n" + "");
                }
            }
            Console.ReadLine();
            /*Console.WriteLine("\n");
          for (int i=10; i>=0;i--) {
                Console.WriteLine($" i equals {i}");
            }
            Console.ReadLine();
            */
        }
    }
}
