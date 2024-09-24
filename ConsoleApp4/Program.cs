using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Direnç türünü seçin: 1) Seri 2) Paralel 3) Çıkış");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Seri direnç hesaplama.");
                Console.Write("Direnç sayısını girin: ");
                int sayi = int.Parse(Console.ReadLine());
                double toplam = 0;

                for (int i = 0; i < sayi; i++)
                {
                    Console.Write($"Direnç {i + 1} değerini girin (Ohm): ");
                    toplam += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Toplam Seri Direnç: {toplam} Ohm");
            }
            else if (secim == 2)
            {
                Console.WriteLine("Paralel direnç hesaplama.");
                Console.Write("Direnç sayısını girin: ");
                int sayi = int.Parse(Console.ReadLine());
                double toplam = 0;

                for (int i = 0; i < sayi; i++)
                {
                    Console.Write($"Direnç {i + 1} değerini girin (Ohm): ");
                    toplam += 1 / double.Parse(Console.ReadLine());
                }
                double sonuc = 1 / toplam;
                Console.WriteLine($"Toplam Paralel Direnç: {sonuc} Ohm");
            }
            else if (secim == 3)
            {
                Console.WriteLine("Programdan çıkılıyor.");
                break; // Döngüden çık
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            }
        }
    }
}
