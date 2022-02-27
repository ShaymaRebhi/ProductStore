using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Domain;


namespace PS.Services
{
      public class ManageProduct
    {
        public Func<Char, List<Product>> FindProduct;
        public Action<Category> ScanProduct;
        public List<Product> lsProduct { get; set; }
        public ManageProduct()
        {
            //FindProduct = Methode1;

            FindProduct = c =>
            {

                List<Product> ls2Product = new List<Product>();
                foreach (Product p in lsProduct)
                {
                    if (p.Name.StartsWith(c))
                    {
                        ls2Product.Add(p);
                    }

                }
                return ls2Product;

            };

            ScanProduct = cat =>
            {
                foreach (Product p in lsProduct)
                {
                    if (p.category.CategoryId == cat.CategoryId)
                    {
                        Console.WriteLine(p);
                    }
                }
            };
        }
        public List<Product> Methode1(char c)
        {
            List<Product> ls2Product = new List<Product>();
            foreach (Product p in lsProduct)
            {
                if (p.Name.StartsWith("c"))
                {
                    ls2Product.Add(p);
                }

            }
            return ls2Product;
        }

        public IEnumerable<Chemical> Get3Chemical(double price)
        {
            var req = from p in lsProduct.OfType<Chemical>()
                      where p.Price > price
                      select p;
            return req.Take(3);
            // ignorer les 2 premiers produits 
            //return req.Skip(2);
        }

        public Double GetAveragePrice()
        {
            return lsProduct.Average(p => p.Price);
        }

        public Double GetMaxPrice()
        {
            return lsProduct.Max(p => p.Price);
        }

        public int GetCountProduct()
        {
            return lsProduct.OfType<Chemical>().Count();
        }
        public IEnumerable<Chemical> GetChemicalCity()
        {
            var req = from c in lsProduct.OfType<Chemical>()
                      orderby c.City
                      select c;
            var req2 = lsProduct.OfType<Chemical>().OrderByDescending(ch => ch.City);
            return req2;
        }
        public IEnumerable<IGrouping<string, Chemical>> GetChemicalGroupByCity()
        {
            var req = from c in lsProduct.OfType<Chemical>()
                      orderby c.City
                      group c by c.City;
            // return req;

            var req2 = lsProduct.OfType<Chemical>().OrderBy(ch => ch.City).GroupBy(ch => ch.City);
            return req2;

        
    

}
    }
}
