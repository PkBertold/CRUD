using Elektronika.Data;
using Microsoft.EntityFrameworkCore;

namespace Elektronika.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ElektronikaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ElektronikaContext>>()))
            {
                if (context == null || context.Alkatresz == null)
                {
                    throw new ArgumentNullException("Null ElektronikaContext");
                }


                if (context.Alkatresz.Any())
                {
                    return;
                }

                context.Alkatresz.AddRange(
                    new Alkatresz
                    {
                        Description = "Processor",
                        MadeBy = "AMD",
                        Type = "Ryzen 5 2600x",
                        ImportPrice = 55000
                    },

                    new Alkatresz
                    {
                    Description = "Processor",
                    MadeBy = "Intel",
                    Type = "Core i5-12400F",
                    ImportPrice = 80000
                    },

                    new Alkatresz
                    {
                        Description = "RAM",
                        MadeBy = "Kingstone",
                        Type = "DDR4 8Gb 3000mhz",
                        ImportPrice = 20000
                    },

                    new Alkatresz
                    {
                        Description = "GPU",
                        MadeBy = "AMD",
                        Type = "Radeon 590",
                        ImportPrice = 120000
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
