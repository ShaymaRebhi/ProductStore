using PS.Domain;
using System;


namespace PS.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //methode 1 d'initialisation d'objet
            Product p = new Product();
            p.Name = "Fraise";
            //date system : p.DateProd=DateTime.Now
            p.DateProd = new DateTime(2022, 01, 01);
            //afficher l'objet
            Console.WriteLine(p.Name);
            //methode 2 d'initilisation
            Product p2 = new Product()
            {
                Name = "Tomate",
                Quantity = 5,
                Price = 200
            };
            Console.WriteLine(p2);

            Provider pr = new Provider();
            pr.password = "shayma";
            pr.confirmPassword = "shayma";
            pr.Email = "shayma.rebhi@gmail.com";
            pr.UserName = "shaymouma";
            //passage par reference 
            //Provider.SetIsApproved(pr);
            //passage par valeur eli hya ghalta 
            Provider.SetIsApproved(pr.password, pr.confirmPassword, pr.IsApproved);
            Console.WriteLine(pr.password +" "+ pr.confirmPassword + " " + pr.IsApproved);
            Console.WriteLine(pr.Login("shaymouma", "er"));

            Product pd = new Product();
            Chemical ch = new Chemical();
            Biological b = new Biological();
            pd.GetMyType();
            ch.GetMyType();
            b.GetMyType();

        }
    }
}
