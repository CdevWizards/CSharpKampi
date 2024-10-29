
using System;


namespace Arrays
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
             #region Foreach 
        // Foreach(1;2;3;4)

        // 1: Değişken Türü
        // 2: Değişken Adı
        // 3: In
        // 4: Liste, Koleksiyon, Dizi
        // string[] cities = {"Budapeşte", "Mersin", "Istanbul", "Antalya", "isparta", "Hatay"};

        // foreach(string city in cities)
        // {
        //     Console.WriteLine(city);
        // }
        // int[] numbers = {45, 90 , 400, 36};

        // foreach(int num in numbers)
        // {
        //     if(num%2==0)
        //     {
        //         Console.WriteLine(num);
        //     }
        // }
        // int[] numbers = {45, 90 , 400, 36};

        // int total =0;

        // foreach(int num in numbers)
        // {
        //     total += num;
        // }
        // Console.WriteLine(total);


        // LİSTELER Bir koleksiyon öğesidir.

        // List<int> numbers = new List<int>()
        // {
        //     2, 3, 4, 5, 6, 7, 8
        // };
        // foreach(int sayi in numbers)
        // {
        // Console.WriteLine(sayi);    
        // }

        // string word ="Merhaba";

        // foreach(char c in word)
        // {
        //     Console.WriteLine(c);
        // }

        #endregion
        #region Örnek Sınav Sistemi Uygulaması

//         Console.WriteLine("****** C# Sınav Uygulaması******");
//         Console.WriteLine();
//         Console.WriteLine();
//         Console.WriteLine("-------------------------");
//         Console.WriteLine("Sınıfınızda Kaç Öğrenci Var");
//         int studentCount =int.Parse(Console.ReadLine());
        
//         // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
//         string[] studentNames = new string[studentCount];
//         double[] studentExamAvg = new double[studentCount];

//         for(int i=0; i<studentCount;i++)
//         {
//             Console.Write($"{i+1}. öğrencinin ismini giriniz");
//             studentNames[i] =Console.ReadLine();
//             double totalExamResult=0;
//  // Her öğrenci için 3 sınav notu girişi 
//             for (int j =0;j < 3;j++)
//             {
//             Console.WriteLine($"{studentNames[i]} öğrencinin {j+1}. not girişini sağlayınız.");
//             double value =double.Parse(Console.ReadLine());
//             totalExamResult += value;       
//             }
//         studentExamAvg[i] = totalExamResult / 3;
//         }

//         //Sınav Ort
//         for(int i =0; i < studentCount; i++)
//         {
//             Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

//         if(studentExamAvg[i] >= 50)
//        {
//         Console.WriteLine($"{studentNames[i]} adlı öğrenci Ortalama Üstündedir.");
//        }
//        else{
//         Console.WriteLine($"{studentNames[i]} adlı öğrenci Ortalama Altındadır.");
//        }
       // öğrencilerin ort ve geçip kalma durumları
        #endregion