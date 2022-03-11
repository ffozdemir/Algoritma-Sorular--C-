using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir pozitif sayı giriniz:");
            int n = int.Parse(Console.ReadLine());
            string[] dizi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. kelimeyi giriniz:");
                dizi[i] = Convert.ToString(Console.ReadLine());
            }
            Array.Reverse(dizi);
            foreach (var i in dizi)
            {
                Console.WriteLine(i);
            }
        }
    }
}
