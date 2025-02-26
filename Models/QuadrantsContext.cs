using System;

// Set up the DB Connection
public class QuadrantsContext : DbContext
{
    public QuadrantsContext(DbContextOptions<QuadrantsContext> options) : base(options)
    {
    }
    // Connect Category table

    public DbSet<Category> Categories { get; set; }

    // Create the conversion between CategoryId and Category Name
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, CategoryName = "Home" },
            new Category { CategoryId = 2, CategoryName = "School" },
            new Category { CategoryId = 3, CategoryName = "Work" },
            new Category { CategoryId = 4, CategoryName = "Church" }
            );
    }

}
