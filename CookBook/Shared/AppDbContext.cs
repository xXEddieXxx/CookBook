using CookBook.Data;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Shared;

public class AppDbContext : DbContext
{
    public DbSet<ShoppingListItem> ShoppingListItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=appdatabase.db");
    }
}