using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider
    {
        //public string ConfirmPassword { get; set; }
        private string ConfirmPassword;
        public string confirmPassword
        {
            get { return ConfirmPassword; }
            set { if (value != Password)
                    Console.WriteLine("ConfirmPassword unvalide");
                else ConfirmPassword = value; }
        }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public Boolean IsApproved { get; set; }
        //public string Password { get; set; }
        // proprité paramétré 
        private string Password;
        public string password {
            get { return Password; }
            set { if (value.Length > 20 || value.Length < 5)
                    Console.WriteLine("le password doit comprendre de 5 á 20 caractére");
                else Password = value; }
        }

        public string UserName { get; set; }
        public List<Product> products { get; set; }

        public static void SetIsApproved(Provider p) {
            p.IsApproved = p.Password.Equals(p.ConfirmPassword);
        }

        public static void SetIsApproved(string pass, string confirmPass, bool isApproved) {
            isApproved = pass.Equals(confirmPass);
        }
        public bool Login(string user, string pass)
        {
            return UserName.Equals(user) && Password.Equals(pass);
        }
        public static void Calculer(int a, int b, ref int c)
        {
            c = a + b;
        }

        // another methode

        public bool Login (string user , string pass , string email=null) {
            if (Email != null)
                return (UserName.Equals(user) && Password.Equals(pass) && Email.Equals(email));
            else
                return UserName.Equals(user) && Password.Equals(pass);
    }

        public  void GetDetail()
        {
            Console.WriteLine("Nom" + UserName);
            //for(int i=0; i< products.Count; i++)
            //{
              //  Console.WriteLine(products[i]);
            //}
            foreach(Product p in products)
            {
                Console.WriteLine(p);
            }
        }
        public void GetProducts(string filterType , string filterValue)
        {
            switch (filterType)
            {
                case "Name":
                    foreach (Product p in products)
                    {
                        if (p.Name == filterValue)
                            Console.WriteLine(p);
                    }
                    break;
                case "dateProd":
                    foreach (Product p in products)
                    {
                        if (p.DateProd == DateTime.Parse(filterValue))
                            Console.WriteLine(p);
                    }
                    break;

                case "Price":
                    foreach (Product p in products)
                    {
                        if (p.Price == Double.Parse(filterValue))
                            Console.WriteLine(p);
                    }
                    break;


            }

        }
    }
        
    
}
