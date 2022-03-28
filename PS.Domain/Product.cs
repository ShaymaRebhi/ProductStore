using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PS.Domain
{
    public class Product
    {
        [Display(Name="Production date")] // kifeh yafichih
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage ="name is required")]
        [MaxLength(50)] // input length
        [StringLength(50)]//property length
        public string Name { get; set; }
        [DataType(DataType.Currency)] // exp ajouter tnd felekher 
        public double Price { get; set; }
        public int ProductId { get; set; }

        public string ImageName { get; set; }
        [Range(0,double.MaxValue)] //positive 
        public int Quantity { get; set; }
       
        public int? CategoryFK { get; set; }
        [ForeignKey("CategoryFK")]
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
