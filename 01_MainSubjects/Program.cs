﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya!");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            //string name;
            //name = "Sevde";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+98 500 480 30 28";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("email Adresi: " + customerEmail);
            //Console.WriteLine("adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");

            //customerName = "ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 25 24";
            //customerEmail = "test@gmail.com";
            //district = "Üsküdar";
            //city = "İstanbul";
//---------------------------------------
           //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");


            #endregion

            #region int Değişkenler

            int numb = 24;
            Console.WriteLine(numb);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 12;
            int friesPrice = 65;
            int pizzaPrice = 250;
            int lemonadePrice = 35;

            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("---- Kola Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("---- Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("---- Kızartma Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("---- Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("----limonata Fiyatı: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** restoran Menü Fiyatları *****");

            int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 2;
            cokeCount = 2;
            waterCount = 0;
            friesCount = 3;
            pizzaCount = 1;
            lemonadeCount = 1;

            totalPrice = (hamburgerPrice * hamburgerCount) + (cokeCount * cokePrice) 
                + (waterCount * waterPrice) + (friesCount * friesPrice) + (pizzaCount * pizzaPrice) 
                + (lemonadeCount * lemonadePrice);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + (hamburgerPrice * hamburgerCount) + " TL");
            Console.WriteLine("Kola Tutarı: " + (cokeCount * cokePrice) + " TL");
            Console.WriteLine("Su Tutarı: " + (waterCount * waterPrice) + " TL");
            Console.WriteLine("Kızartma Tutarı: " + (friesCount * friesPrice) + " TL");
            Console.WriteLine("Pizza Tutarı: " + (pizzaCount * pizzaPrice) + " TL");
            Console.WriteLine("Limonata Tutarı: " + (lemonadeCount * lemonadePrice) + " TL");
            Console.WriteLine();
            Console.WriteLine("Toplam ödenecek Tutr: " + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}