using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 8;
            int v = 11;

            /*Linea Superios*/
            for (int i = 0; i < v; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        
            /*Centro*/
            for (int i = 0; i < h - 6; i++)
            {
                Console.Write('*');
                for (int j = 0; j < v - 2; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('*');
            }

            /*Linea Mitad*/
            for (int i = 0; i < v; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();

            /*Cuadro Cuperior*/
            for (int i = 0; i < h - 5; i++)
            {

                Console.Write('*');
                for (int jd = 0; jd < v - 7; jd++)
                {
                    Console.Write(' ');
                }

                Console.Write('*');
                for (int jd = 0; jd < v - 7; jd++)
                {
                    Console.Write(' ');
                }


                for (int j = 0; j < v -11; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('*');
            }
            
        }
    }
}
