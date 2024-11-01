using System;
using System.Data.SqlClient;
using System.Data;


namespace DatabaseProject 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADO.NETs

            Console.WriteLine("---C# Ürün Kategori Bilgi Sistemi---");
            Console.WriteLine("");
            Console.WriteLine("");

            string? tableNumber;

            Console.WriteLine("-------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen Getirmek istediğiniz tablo numarasını giriniz:");
            tableNumber = Console.ReadLine();
 Console.WriteLine("-------------------");

            SqlConnection connection = new SqlConnection("Data Source=ULUSOY\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);   // C# ile oluşturduğum sorgu ile sql veritabanı arasında köprü görevi görür.
            DataTable dataTable = new DataTable();  // Verilere ram belleğe almamızı sağlayacak...
            adapter.Fill(dataTable);
            connection.Close();
            foreach(DataRow row in dataTable.Rows)
            {
                    foreach(var item in row.ItemArray)
                    {
                        Console.WriteLine(item.ToString());
                    }
            }
            Console.Read();
        }
    }
}