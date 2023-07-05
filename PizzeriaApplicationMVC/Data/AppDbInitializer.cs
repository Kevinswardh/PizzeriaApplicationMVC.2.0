using PizzeriaApplicationMVC.Models;
using System.Collections.Generic;
namespace PizzeriaApplicationMVC.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Pizza1
                if (!context.Produkter.Any())
                {
                    context.Produkter.AddRange(new List<Products>()
                    {
                        new Products()
                        {
                            PizzaName = "Margaritha",
                            Price = 90,
                            PizzaIngre = "Tomat, Ost",
                            Category = "Klass 1"

                        },
                        new Products()
                        {
                            PizzaName = "Hawaii",
                            Price = 100,
                            PizzaIngre = "Tomat, Ost, Skinka, Ananas",
                            Category = "Klass 2"
                        },
                        new Products()
                        {
                            PizzaName = "La Mare",
                            Price = 105,
                            PizzaIngre = "Tomat, Ost, Skinka, Räkor, Ananas, Champinjoner",
                            Category = "Klass 3"
                        },
                        new Products()
                        {
                            PizzaName = "Kebab Pizza",
                            Price = 110,
                            PizzaIngre = "Tomat, Ost, Kebab, Lök",
                            Category = "Kebab Pizzor"
                        },
                        new Products()
                        {
                            PizzaName = "Belinda",
                            Price = 105,
                            PizzaIngre = "Tomat, Ost, Kebab, Lök",
                            Category = "Bacon Pizzor"
                        },
                        new Products()
                        {
                            PizzaName = "Amigo",
                            Price = 110,
                            PizzaIngre = "Tomat, Ost, Köttfärs, Paprika, Champinjoner",
                            Category = "Köttfärs Pizzor"
                        },
                        new Products()
                        {
                            PizzaName = "Prima",
                            Price = 110,
                            PizzaIngre = "Tomat, Ost, Kyckling, Räkor, Banan, Curry",
                            Category = "Kyckling Pizzor"
                        },
                        new Products()
                        {
                            PizzaName = "Capalccino",
                            Price = 115,
                            PizzaIngre = "Tomat, Ost, Fläskfilé, Skinka, Gorgonzola, Lök",
                            Category = "Fläskfilé Pizzor"
                        },
                        new Products()
                        {
                            PizzaName = "Romana",
                            Price = 120,
                            PizzaIngre = "Tomat, Ost, Oxfilé, Lök, Champinjoner, Bearnaisesås",
                            Category = "Oxfilé Pizzor"
                        },
                        new Products()
                        {
                            PizzaName = "Kebab Rulle",
                            Price = 105,
                            PizzaIngre = "Mixed sallad, Kebab, Sås",
                            Category = "Rullar"
                        },
                        new Products()
                        {
                            PizzaName = "Pita Kebab",
                            Price = 100,
                            PizzaIngre = "Mixed sallad, Kebab, Sås",
                            Category = "Pita"
                        },
                        new Products()
                        {
                            PizzaName = "Kebab Tallrik",
                            Price = 100,
                            PizzaIngre = "Mixed sallad, Kebab, Prommes, Sås",
                            Category = "Tallrikar"
                        },
                        new Products()
                        {
                            PizzaName = "Vitlöksås",
                            Price = 100,
                            PizzaIngre = "",
                            Category = "Såser"
                        },
                        new Products()
                        {
                            PizzaName = "Coca-Cola",
                            Price = 100,
                            PizzaIngre = "Mixed sallad, Kebab, Prommes, Sås",
                            Category = "Dricka"
                        },
                    }) ;
                    context.SaveChanges();

                    
                }
                 
                //PizzaKlass2s

                //PizzaKlass3s

                //PizzaKebab


                }
        }


    }
}
