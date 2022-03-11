using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir pozitif sayı giriniz:");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı giriniz");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var i in dizi)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Bu sayı çift sayıdır:" + i);
                }
            }


        }
    }
}
