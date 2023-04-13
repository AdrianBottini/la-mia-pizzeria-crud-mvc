using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_crud_mvc.Models
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=pizzeriaDB;Integrated Security=True;Pooling=False;Encrypt=False;");
        }
        public void seed()
        {
            if (!Pizzas.Any())
            {
                var seed = new Pizza[]
                {
                    new Pizza
                    {
                        Name = "Marinara",
                        Description = "pomodoro, origano, aglio ed olio",
                        Foto = "/img/pizza01.webp",
                        Price = 4,
                    },
                    new Pizza
                    {
                        Name = "Margherita",
                        Description = "pomodoro e mozzarella",
                        Foto = "/img/pizza02.jpg",
                        Price = 5,
                    },
                    new Pizza
                    {
                        Name = "Calabrese",
                        Description = "pomodoro, mozzarella e salame piccante",
                        Foto ="/img/pizza03.jpg",
                        Price = 6,
                    },
                    new Pizza
                    {
                        Name = "Mortadella e pistacchi",
                        Description = "pomodoro, mozzarella, mortadella e pistacchi",
                        Foto = "/img/pizza04.webp",
                        Price = 8,
                    },
                    new Pizza
                    {
                        Name = "Romana",
                        Description = "pomodoro, mozzarella, acciughe, capperi, olive e origano",
                        Foto = "/img/pizza05.jpg",
                        Price = 7,
                    },
                    new Pizza
                    {
                        Name = "Prosciutto e funghi",
                        Description = "pomodoro, mozzarella, prosciutto cotto e funghi",
                        Foto = "/img/pizza06.jpg",
                        Price = 8,
                    }
                };
                Pizzas.AddRange(seed);

                SaveChanges();
            }
        }
    }
}
