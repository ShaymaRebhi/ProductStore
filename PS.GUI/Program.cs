using PS.Domain;
using System;
using PS.Services;
using System.Collections.Generic;
using PS.Data;

namespace PS.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product p1 = new Product();

            p1.Name = "Fraises";

            p1.DateProd = new DateTime(2022, 1, 31);

            p1.DateProd = new DateTime(2020, 10, 20);

            p1.Description = "this is a description of product";
            p1.Price = 200;


            Product p2 = new Product()
            {
                Name = "Fraises",
                Quantity = 5,
                DateProd = DateTime.Now,
                Description = "this is a description of product",
                Price = 100
            };

            Console.WriteLine(p2);



            Provider p = new Provider()
            {
                UserName = "shayma",
                Email = "shayma.rebhi@esprit.tn",
                password = "1234567",
                confirmPassword = "1234567"
            };

            //passage par réference

            // Provider.SetIsApproved(p);

            //passage par valeur

            Provider.SetIsApproved(p.password, p.confirmPassword, p.IsApproved);

            Console.WriteLine(p.IsApproved);

            int j = 5;
            int i = 3;
            int k = 2;

            Provider.Calculer(i, j, ref k);

            Console.WriteLine("Login: " + p.Login("shayma", "1234567"));

            Console.WriteLine("Login: " + p.Login("shayma", "1234567", "shayma.rebhi@esprit.tn"));
            Console.WriteLine(k);

            Console.WriteLine("-------------------------------------------------------------------");

            Product ps = new Product();
            Chemical c1 = new Chemical()
            {
                Name = "chemical1",
                Price = 50,
               // Myadress.City = "paris"
            };
            c1.Myadress.City = "paris";

            Chemical c2 = new Chemical()
            {
                Name = "chemical2",
                Price = 150,
               
            };
            c2.Myadress.City = "paris";

            Chemical c3 = new Chemical()
            {
                Name = "chemical3",
                Price = 20,
                
            };
            c3.Myadress.City = "tunis";
            Chemical c4 = new Chemical()
            {
                Name = "chemical4",
                Price = 150,
               
            };
            c4.Myadress.City = "madrid";
            Product b = new Biological();
            ps.GetMyType();
            c1.GetMyType();
            b.GetMyType();

            //Collection

            List<Product> products = new List<Product>
            {
                p1,c1,c2,c3,c4
            };


            products.Add(p2);

            p.products = products;
            Console.WriteLine("\n");
            p.GetDetail();

            Console.WriteLine("la methode getProducts");
            p.GetProducts("dateProd", "2020/10/20");


            Console.WriteLine("---------------------déléguer-----------------------------");

            ManageProduct mp = new ManageProduct();
            mp.lsProduct = products;

            foreach (Product pp in mp.FindProduct('F'))
            {
                Console.WriteLine(pp);
            }
            Console.WriteLine("------------------------tester les methode de la class manage product----------------------");
            foreach (Chemical ch in mp.Get3Chemical(10))
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("Avrg price: " + mp.GetAveragePrice() + "count" + mp.GetCountProduct() + "Max" + mp.GetMaxPrice());
            Console.WriteLine("------------------------order by city----------------------");

            foreach (Chemical ch in mp.GetChemicalCity())
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("------------------------order by city----------------------");

            foreach (var g in mp.GetChemicalGroupByCity())
            {
                Console.WriteLine(g.Key + ": ");
                foreach (Chemical ch in g)
                {
                    Console.WriteLine(ch);
                }

            }
            Console.WriteLine("------------------------order by city----------------------");

            Console.WriteLine("------------------------INSERTION DANS LA BASE DE DONNEE----------------------");
            PSContext ctx = new PSContext();

            ctx.Products.Add(p2);
            ctx.Chemicals.Add(c1);
            ctx.SaveChanges();

        }

    }

    }
