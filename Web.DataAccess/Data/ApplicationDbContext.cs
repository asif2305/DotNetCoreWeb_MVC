using Microsoft.EntityFrameworkCore;
using Web.Models.Models;

namespace Web.DataAccess.Data
{
	public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }


		// to seed the data by default
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

			modelBuilder.Entity<Product>().HasData(
			   new Product
			   {
				   Id = 1,
				   Title = "Cotton Candy",
				   Author = "Abby Muscles",
				   Description = "This is first description",
				   ISBN = "WS102212555",
				   ListPrice = 70,
				   Price = 65,
				   Price50 = 60,
				   Price100 = 40,
				   CategoryId = 1,
				   ImageUrl = ""
			   }, new Product
			   {
				   Id = 2,
				   Title = "Cotton Candy_2",
				   Author = "Abby Muscles_2",
				   Description = "This is first description_2",
				   ISBN = "WS102212598",
				   ListPrice = 50,
				   Price = 60,
				   Price50 = 55,
				   Price100 = 30,
				   CategoryId = 2,
				   ImageUrl = ""
			   }, new Product
			   {
				   Id = 3,
				   Title = "Cotton Candy_3",
				   Author = "Abby Muscles",
				   Description = "This is first description_3",
				   ISBN = "WS102212563",
				   ListPrice = 70,
				   Price = 65,
				   Price50 = 60,
				   Price100 = 40,
				   CategoryId = 3,
				   ImageUrl = ""
			   }, new Product
			   {
				   Id = 4,
				   Title = "Cotton Candy_4",
				   Author = "Abby Muscles_4",
				   Description = "This is first description_4",
				   ISBN = "WS102212750",
				   ListPrice = 60,
				   Price = 63,
				   Price50 = 52,
				   Price100 = 46,
				   CategoryId = 2,
				   ImageUrl = ""
			   }, new Product
			   {
				   Id = 5,
				   Title = "Cotton Candy_5",
				   Author = "Abby Muscles_5",
				   Description = "This is first description_5",
				   ISBN = "WS102212555",
				   ListPrice = 70,
				   Price = 65,
				   Price50 = 60,
				   Price100 = 40,
				   CategoryId = 3,
				   ImageUrl = ""
			   },
				new Product
				{
					Id = 6,
					Title = "Cotton Candy_6",
					Author = "Abby Muscles",
					Description = "This is first description_6",
					ISBN = "WS1022125023",
					ListPrice = 85,
					Price = 65,
					Price50 = 80,
					Price100 = 20,
					CategoryId= 2,
					ImageUrl =""
				}

			  );
		}
    }
}
