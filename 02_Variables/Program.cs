using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            ////double number;
            ////number = 5.20;
            ////Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            double pearPrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            pearPrice = 12.30; // Değiştirildi (14.85'ten)
            orangePrice = 18.50; // Değiştirildi (20.95'ten)
            strawberryPrice = 48.75; // Değiştirildi (45'ten)
            potatoPrice = 11.20; // Değiştirildi (9.74'ten)
            tomatoPrice = 7.50; // Değiştirildi (6.88'ten)

            Console.WriteLine("---- Armut Birim Fiyatı: " + pearPrice);
            Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice);
            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice);
            Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice);
            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice);

            double pearGram, orangeGram, strawGram, potatoGram, tomatoGram;

            pearGram = 1.100; // Değiştirildi (1.245'ten)
            orangeGram = 2.800; // Değiştirildi (2.650'ten)
            strawGram = 0.850; // Değiştirildi (0.750'ten)
            potatoGram = 4.500; // Değiştirildi (4.859'ten)
            tomatoGram = 3.600; // Değiştirildi (3.745'ten)

            double totalPrice;

            Console.WriteLine();

            Console.WriteLine("Alınan Ürün: Armut, Birim Fiyatı: " + pearPrice
                + ", Gramaj: " + pearGram + ", Toplam Tutar: " + pearGram * pearPrice);
            Console.WriteLine("Alınan Ürün: Portakal, Birim Fiyatı: " + orangePrice
                + ", Gramaj: " + orangeGram + ", Toplam Tutar: " + orangeGram * orangePrice);
            Console.WriteLine("Alınan Ürün: Çilek, Birim Fiyatı: " + strawberryPrice
                + ", Gramaj: " + strawGram + ", Toplam Tutar: " + strawGram * strawberryPrice);
            Console.WriteLine("Alınan Ürün: Patates, Birim Fiyatı: " + potatoPrice
                + ", Gramaj: " + potatoGram + ", Toplam Tutar: " + potatoGram * potatoPrice);
            Console.WriteLine("Alınan Ürün: Domates, Birim Fiyatı: " + tomatoPrice
                + ", Gramaj: " + tomatoGram + ", Toplam Tutar: " + tomatoGram * tomatoPrice);

            Console.WriteLine();

            totalPrice = (pearGram * pearPrice) + (orangeGram * orangePrice)
                + (strawGram * strawberryPrice) + (potatoGram * potatoPrice) + (tomatoGram * tomatoPrice);

            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read();

        }
    }
}
