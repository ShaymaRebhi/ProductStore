using System;
using System.Collections.Generic;
using System.Text;
using PS.Domain;


namespace PS.Services
{
    class ManageProduct
    {
        public Func<Char, List<Product>> FindProduct;
        public Action<Category> ScanProduct;
        public List<Product> LsProduct { get; set; }
        public List<Product> Methode1 (char c)
        {

        }
    }
}
