using Microsoft.EntityFrameworkCore;
using Product.Data;

namespace Product.Models
{
    public class SendData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProductContext>>()))
            {
                // Look for any movies.
                if (context.Item.Any())
                {
                    return;   // DB has been seeded
                }

                context.Item.AddRange(
                    new Item
                    {
                        Id = "P001",
                        Name = "osii 舒壓按摩椅",
                        Price = 98000,
                        Quantity = 5
                    },

                    new Item
                    {
                        Id = "P002",
                        Name = "網友最愛起司蛋糕",
                        Price = 1200,
                        Quantity = 50
                    },

                    new Item
                    {
                        Id = "P003",
                        Name = "真愛密碼項鍊",
                        Price = 8500,
                        Quantity = 20
                    }                  
                );
                context.SaveChanges();
            }
        }
    }
}
