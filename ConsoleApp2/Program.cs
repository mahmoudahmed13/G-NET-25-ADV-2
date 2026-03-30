namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                new Product { Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25 },
                new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                new Product { Id=9,Name="Headphones", Category="Electronics", Price=150, Stock=40 }
            };

            #region Task01

            //Console.WriteLine("--- Electronics —---");
            //Func<Product, bool> func = (Product product) => product.Category == "Electronics";
            //List<Product> products01 = Product.SearchProducts(catalog,func);
            //foreach (Product product in products01)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine("--- Under $50 --- ");
            //List<Product> products02 = Product.SearchProducts(catalog, (Product product) => product.Price < 50);
            //foreach (Product product in products02)
            //{
            //    Console.WriteLine(product);
            //}

            //Console.WriteLine("--- Stock > 0 --- ");
            //List<Product> products03 = Product.SearchProducts(catalog,(product) => product.Stock > 0);
            //foreach (Product product in products03)
            //{
            //    Console.WriteLine(product);
            //}

            //Console.WriteLine("--- Under $100 --- ");
            //List<Product> products04 = Product.SearchProducts(catalog,(product) => product.Price < 100);
            //foreach (Product product in products04)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion
        }
    }
}
