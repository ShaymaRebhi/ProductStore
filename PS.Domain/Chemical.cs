using System;
using System.Collections.Generic;
using System.Text;



namespace PS.Domain
{
    public class Chemical : Product
    {
        public Adress Myadress { get; set; } = new Adress();        public string LabName { get; set; }           public  void GetMyType()
        {
            base.GetMyType();
            Console.WriteLine("chemical");
        }        public override string ToString()
        {
            return base.ToString() + "city: " + Myadress.City;
        }    }
}
