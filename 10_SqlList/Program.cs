using System;
using System.Data.SqlClient;
using System.Data;


namespace DatabaseCrud 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud--> Crute, Read, Update, Delete 

             Console.WriteLine("***Menü Sipariş İşlem Paneli****");
            // Console.Write("Eklemek istediğiniz kategori adi");

            // string categoryName=Console.ReadLine();
#region Kategori Ekleme İşlemi
            // SqlConnection connection = new SqlConnection("Data Source=ULUSOY\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            // connection.Open();
            // //Addition Process ,, Sql Command
            // SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            // command.Parameters.AddWithValue("@p1", categoryName);
            // command.ExecuteNonQuery();
            // connection.Close();

            // Console.WriteLine("Kategori Başarılı Bir Şekilde Eklendi.");
            //Console.Read();
    #endregion
#region  Ürün Ekleme İşlemi
 
//  string? productName;
//  decimal productPrice;
//  //bool productStatus;

//  Console.Write("Ürün Adi:");
//  productName = Console.ReadLine();
//  Console.Write("Ürün Fiyati:");
//  productPrice=decimal.Parse(Console.ReadLine());
 
//  SqlConnection connection = new SqlConnection("Data Source=ULUSOY\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"); 
//  connection.Open();
//  SqlCommand command=new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);

//  command.Parameters.AddWithValue("@productName",productName);
//  command.Parameters.AddWithValue("@productPrice",productPrice);
//  command.Parameters.AddWithValue("@productStatus",true);
// command.ExecuteNonQuery();
// connection.Close();
// Console.Write("Ürün Eklemesi Başarılı");
// Console.Read();
#endregion
#region ürün Listeleme İşlemi

//  SqlConnection connection = new SqlConnection("Data Source=ULUSOY\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"); 
//  connection.Open();
//  SqlCommand command =new SqlCommand("Select * from TblProduct", connection);
//  SqlDataAdapter adapter = new SqlDataAdapter(command);
//  DataTable dataTable = new DataTable();
//  adapter.Fill(dataTable);

//  foreach(DataRow row in dataTable.Rows)
//  {
//     foreach(var item in row.ItemArray)
//     {
//         Console.WriteLine(item.ToString()+ " ");
//     }
//  }
//  connection.Close();
#endregion
#region Ürün Silme İşlemi 
//   Console.Write("Silinecek Ürün ID: ");
//   int productId = int.Parse(Console.ReadLine());
//   SqlConnection baglanti = new SqlConnection("Data Source=ULUSOY\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"); 
//   baglanti.Open();
//   SqlCommand command = new SqlCommand ("Delete From TblProduct Where Productid=@productId",baglanti);
//   command.Parameters.AddWithValue("@productId",productId);
//   command.ExecuteNonQuery();

//   baglanti.Close();
// Console.WriteLine("Silme İşlemi Yapıldı.");
 
 #endregion    
#region Ürün Güncelleme İşlemi


Console.WriteLine("Güncellenecek Ürün Id: ");
int productId = int.Parse(Console.ReadLine());
//--
Console.WriteLine("Güncellenecek Ürün Adı: ");
string productName = Console.ReadLine();
//--
Console.WriteLine("Güncellenecek Ürün Fiyatı: ");
decimal productPrice = decimal.Parse(Console.ReadLine());
//--
SqlConnection baglanti = new SqlConnection("Data Source=ULUSOY\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"); 
baglanti.Open();

SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productname,ProductPrice=@productPrice where Productid=@productId",baglanti);

command.Parameters.AddWithValue("@productName",productName);
command.Parameters.AddWithValue("@productPrice",productPrice);
command.Parameters.AddWithValue("@productId",productId);
command.ExecuteNonQuery();
baglanti.Close();

Console.Write("Update İşlemi Yapıldı!!.");

 #endregion
        }
        
    }
}
