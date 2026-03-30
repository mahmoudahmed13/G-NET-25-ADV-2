using System.Reflection.Emit;

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
                new Product { Id=9,Name="Headphones", Category="Electronics", Price=150, Stock=15 }
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

            #region 3.1 Print Reports

            //Console.WriteLine("--- Short Report --- ");
            //Product.PrintReport(catalog, product => Console.WriteLine($"{product.Name} - ${product.Price}"));

            //Console.WriteLine("--- Deltals Report --- ");
            //Product.PrintReport(catalog, product => Console.WriteLine($"[{product.Category}]{product.Name} " +
            //    $"| Price: ${product.Price} | Stock: {product.Stock}")); 
            #endregion

            #region 3.2. Transform Products 

            //Console.WriteLine("--- Summary List --- ");
            //List<string> priceLabel = Product.TransformProducts(catalog, product => $" ${product.Price}");
            //priceLabel.ForEach(Print);
            //Console.WriteLine("--- Price Labels --- ");
            //List<string> priceLabels = Product.TransformProducts(catalog, product => product.Price > 100 ? "Expensive" : "Affordable ");
            //priceLabels.ForEach(Print); 
            #endregion

            #region 3.3. Filter Products

            //List<Product> productsLowStack = Product.FilterProducts(catalog, product => product.Stock < 20);
            //foreach (Product product in productsLowStack)
            //{
            //    LowStockAlert(product);
            //} 
            #endregion

        }
        public static void Print(string print)
        {
            Console.WriteLine(print);
        }
        //[LOW STOCK] Laptop: only 10 left! 
        public static void LowStockAlert(Product product)
        {
            Console.WriteLine($"[LOW STOCK] {product.Name} : only {product.Stock} left!");
        }

    }
}
