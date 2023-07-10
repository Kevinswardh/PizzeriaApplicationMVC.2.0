using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace PizzeriaApplicationMVC.Models
{
    public class Products
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }

        //ProductName
        [Display(Name = "Namn")]
        [Required(ErrorMessage = "Ett namn saknas")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Måste vara mellan 3 and 100 bokstäver")]
        public string PizzaName { get; set; }

        //FullName
        [Display(Name = "Ingredienser")]
        [AllowNull]
        public string? PizzaIngre { get; set; }

        //Biography
        [Display(Name = "Pris")]
        [Required(ErrorMessage = "Du måste ha ett pris")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Du mäste välja en kategori")]
        public int Category { get; set; }
    }
}
