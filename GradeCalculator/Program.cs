using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç öğrenci ismi yazılacak?");
            byte satir = byte.Parse(Console.ReadLine());
            String[,] hesaplama = new string[satir + 1, 6];
            hesaplama[0, 0] = "Ad";
            hesaplama[0, 1] = "Soyad";
            hesaplama[0, 2] = "Vize Notu";
            hesaplama[0, 3] = "Final Notu";
            hesaplama[0, 4] = "Ortalama";
            hesaplama[0, 5] = "Harf Notu";
            for (
                int i = 1; i < hesaplama.GetLength(0); i++)
            {
                for (int j = 0; j < hesaplama.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("İsminizi giriniz:");
                        hesaplama[i, j] = Console.ReadLine();
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("Soy adınızı giriniz:");
                        hesaplama[i, j] = Console.ReadLine();
                    }
                    else if (j == 2)
                    {
                        Console.WriteLine("Vize notunuzu giriniz:");
                        hesaplama[i, j] = Console.ReadLine();
                    }
                    else if (j == 3)
                    {
                        Console.WriteLine("Final notunuzu  giriniz:");
                        hesaplama[i, j] = Console.ReadLine();
                    }
                    else if (j == 4)
                    {
                        float vize1 = float.Parse(hesaplama[i, 2]);
                        float final1 = float.Parse(hesaplama[i, 3]);
                        string sonuc = Convert.ToString(vize1 * 0.4 + final1 * 0.6);
                        hesaplama[i, j] = sonuc;
                    }
                    else if (j == 5)
                    {
                        float harf1 = float.Parse(hesaplama[i, 4]);

                        if (harf1 > 87.5)
                        {
                            hesaplama[i, j] = "AA";
                        }
                        else if (harf1 > 75)
                        {
                            hesaplama[i, j] = "BA";
                        }
                        else if (harf1 > 62.5)
                        {
                            hesaplama[i, j] = "CB";
                        }
                        else if (harf1 > 50)
                        {
                            hesaplama[i, j] = "CC";
                        }
                        else if (harf1 > 37.5)
                        {
                            hesaplama[i, j] = "DC";
                        }
                        else if (harf1 > 25)
                        {
                            hesaplama[i, j] = "DD";
                        }
                        else if (harf1 > 12.5)
                        {
                            hesaplama[i, j] = "FD";
                        }
                        else
                        {
                            hesaplama[i, j] = "FF";
                        }
                    }
                }
            }
            for (int i = 0; i < hesaplama.GetLength(0); i++)
            {
                for (int j = 0; j < hesaplama.GetLength(1); j++)
                {
                    Console.Write(hesaplama[i, j] + "\t" + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}