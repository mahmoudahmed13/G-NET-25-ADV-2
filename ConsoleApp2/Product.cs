namespace ConsoleApp2
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> func)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in products)
            {
                if (func(product))
                    result.Add(product);
            }
            return result;
        }

        public override string ToString() => $"{Name} - ${Price} (Stoke: {Stock})";
        public static void PrintReport(List<Product> products, Action<Product> action)
        {

            foreach (Product product in products)
                action(product);
        }

        public static List<string> TransformProducts(List<Product> products, Func<Product,string> func)
        {
            var result = new List<string>();
            foreach (Product product in products)
            {

                result.Add($"{product.Name} :{func.Invoke(product)}");
            }
            return result;
        }
    }
}

