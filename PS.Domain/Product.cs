using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Product
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }

        public string ImageName { get; set; }
        public int Quantity { get; set; }
        public Category category { get; set; }
        public List<Provider> providers { get; set; }
        public override string ToString()
        {
            return "Name : " +Name+ " Quantity : " +Quantity+ " Price : " +Price;
        }

        public void GetMyType()
        {
           
            Console.Write("je suis un produit ");
        }



    }
}
