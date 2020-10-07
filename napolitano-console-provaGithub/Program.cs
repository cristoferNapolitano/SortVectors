using System;

namespace napolitano_console_provaGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[] { 3, 6, 26, 23, 34, 84, 27, 64, 39 ,83};

            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Ordina(array);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadKey();
        }

        static void Ordina(int[] array)
        {
            Array.Sort(array);
        }
    }
}
