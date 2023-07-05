using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PizzeriaApplicationMVC.Models
{
    public class Products
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }

        //ProductName
        [Display(Name = "Name")]
        [Required(ErrorMessage = "A name is required")]
        public string PizzaName { get; set; }

        //FullName
        [Display(Name = "Name")]
        [Required(ErrorMessage = "A name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 50 chars")]
        public string PizzaIngre { get; set; }

        //Biography
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Prica is Required")]
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
