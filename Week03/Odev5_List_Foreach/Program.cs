using Odev5_List_Foreach.Models;

List<Product> products = new List<Product>();
Product cay = new Product { Id = 1, Name = "Çay", Price = 20 };
products.Add(cay);
Product ayran = new Product { Id = 2, Name = "Ayran", Price = 30 };
products.Add(ayran);
Product kola = new Product { Id = 3, Name = "Kola", Price = 50 };
products.Add(kola);
Product su = new Product { Id = 4, Name = "Su", Price = 40 };
products.Add(su);

Console.WriteLine("=== ÜRÜN LİSTESİ ===");
if (products.Count == 0)
{
    Console.WriteLine("Ürün yok");
}
else
{
    foreach(Product product in products)
    {
       product.Display(); 
       
    }
    Console.WriteLine($"Toplam ürün sayısı: {products.Count}");
    
}