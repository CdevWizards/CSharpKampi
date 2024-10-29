 using System;


namespace Arrays
{
    internal class Program 
    {
        static void Main(string[] args)
        {
 #region  Void Metotlar 7.Ders  
        //()
        //Customer --> Listele, ekle, sil, güncelle 
        //Geriye Değer Döndürmeyen Metotlar
        // 

        // void CustomerList()
        // {
        // Console.WriteLine("Ali Yıldız");
        // Console.WriteLine("Ayşe Can");
        // Console.WriteLine("Hakan Yıldız");
        // }
        // CustomerList();
        
        
         #endregion 
         #region Geriye Değer Döndürmeyen String Parametreli Metotlar
         
        //  void WriteMethod(string custumerName)
        //  {
        //     Console.WriteLine(custumerName);

        //  }
        //  WriteMethod("Mehmet Yıldırım");

        // void CustomerCard(string name,string surName)
        // {
        //     Console.WriteLine("Müşteri" + name + ""+surName);
        // }

        // CustomerCard("Mehmet", "Yıldız");
        // CustomerCard("Ali", "Yıldız");
//Geriye Değer Döndürmeyen İNT Parametreli Metotlar

// void Sum(int number1, int number2, int number3)
// {
//     int result = number1 +number2 + number3;
//     Console.WriteLine(result);
// }    
//     Sum(4,5,6);
    #endregion
    #region Geriye Değer Döndüren Metotlar
    
    // string CustomerName()
    // {
    //     return " Buse Yıldız";
    // }
    // CustomerName();

    // string StudentCard()
    // {
    //     string name = "Ali";
    //     string surname ="Kaya";
    //     return name + " " + surname;
    //         }
    //         Console.WriteLine(StudentCard());

  //  Geriye Değer Döndüren string parametreli Metotlar
      
    //   string CountryCard(string countryName, string capital, string flagColor)
    //   {
    //     string cardInfo=countryName + " "+capital+" "+ flagColor;
    //     return cardInfo;
    //   }
    //   string x,y,z;
    //   Console.Write("Ülke Adını Giriniz");
    //   x =Console.ReadLine();

    //   Console.Write("Başkenti Giriniz");
    //   y =Console.ReadLine();

    //   Console.Write("Bayrak Rengini Giriniz");
    //   z =Console.ReadLine();

    //  Console.WriteLine(CountryCard(x,y,z));

    // Geriye Değer Döndüren Int Parametreli Metotlar
    
    // int Sum(int number1, int number2)
    // {
    //   int result = number1 + number2;
    //   return result;
    // }
    // Console.WriteLine(Sum(48, 55));

    string ExamResult(string student,int exam1, int exam2, int exam3)
    {
      int result=(exam1 + exam2 + exam3) / 3;
      if (result >= 50)
      {
        return student + "İsimli öğrenci sınavı geçti";
      }
      else 
      {
        return student +  "Öğrenci Başarısız oldu";
      }
    }
    Console.WriteLine(ExamResult("Ali", 50, 60, 40));
    Console.WriteLine(ExamResult("Ayşe", 50, 60, 40));

    Console.Read();
    #endregion
      }
}
}