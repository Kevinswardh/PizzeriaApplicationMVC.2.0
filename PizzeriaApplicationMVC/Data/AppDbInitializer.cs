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
                            Category = 1

                        },
                        new Products()
                        {
                            PizzaName = "Hawaii",
                            Price = 100,
                            PizzaIngre = "Tomat, Ost, Skinka, Ananas",
                            Category = 2
                        },
                        new Products()
                        {
                            PizzaName = "La Mare",
                            Price = 105,
                            PizzaIngre = "Tomat, Ost, Skinka, Räkor, Ananas, Champinjoner",
                            Category = 3
                        },
                        new Products()
                        {
                            PizzaName = "Kebab Pizza",
                            Price = 110,
                            PizzaIngre = "Tomat, Ost, Kebab, Lök",
                            Category = 4
                        },
                        new Products()
                        {
                            PizzaName = "Belinda",
                            Price = 105,
                            PizzaIngre = "Tomat, Ost, Kebab, Lök",
                            Category = 5
                        },
                        new Products()
                        {
                            PizzaName = "Amigo",
                            Price = 110,
                            PizzaIngre = "Tomat, Ost, Köttfärs, Paprika, Champinjoner",
                            Category = 6
                        },
                        new Products()
                        {
                            PizzaName = "Prima",
                            Price = 110,
                            PizzaIngre = "Tomat, Ost, Kyckling, Räkor, Banan, Curry",
                            Category = 7
                        },
                        new Products()
                        {
                            PizzaName = "Capalccino",
                            Price = 115,
                            PizzaIngre = "Tomat, Ost, Fläskfilé, Skinka, Gorgonzola, Lök",
                            Category = 8
                        },
                        new Products()
                        {
                            PizzaName = "Romana",
                            Price = 120,
                            PizzaIngre = "Tomat, Ost, Oxfilé, Lök, Champinjoner, Bearnaisesås",
                            Category = 9
                        },
                        new Products()
                        {
                            PizzaName = "Kebab Rulle",
                            Price = 105,
                            PizzaIngre = "Mixed sallad, Kebab, Sås",
                            Category = 10
                        },
                        new Products()
                        {
                            PizzaName = "Pita Kebab",
                            Price = 100,
                            PizzaIngre = "Mixed sallad, Kebab, Sås",
                            Category = 11
                        },
                        new Products()
                        {
                            PizzaName = "Kebab Tallrik",
                            Price = 100,
                            PizzaIngre = "Mixed sallad, Kebab, Prommes, Sås",
                            Category = 12
                        },
                        new Products()
                        {
                            PizzaName = "Vitlöksås",
                            Price = 100,
                            PizzaIngre = "",
                            Category = 13
                        },
                        new Products()
                        {
                            PizzaName = "Coca-Cola",
                            Price = 100,
                            PizzaIngre = "",
                            Category = 14
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
