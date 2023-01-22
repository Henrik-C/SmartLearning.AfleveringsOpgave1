using Microsoft.EntityFrameworkCore;

namespace SmartLearning.AfleveringsOpgave1.Models
{
    public class ShoppingListDbContext : DbContext
    {
        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options) : base(options) { }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
