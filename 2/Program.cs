using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen pozitif bir sayı daha giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. pozitif sayıyı giriniz:");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var i in dizi)
            {
                if (i == m)
                {
                    Console.WriteLine(i);
                }

                else if (i % m == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
