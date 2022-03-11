using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız:");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(" ");
            Console.WriteLine("Cümledeki kelime sayısı: " + kelimeler.Length);

            string harfler = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";

            int harfsayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (harfler.Contains(cumle[i]))
                {
                    harfsayac++;
                }
            }

            Console.WriteLine("Cümlede " + harfsayac + " adet harf vardır.");

        }
    }
}
