using BasicApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Data
{
    public class BasicApiContext : DbContext
    {
        public BasicApiContext(DbContextOptions<BasicApiContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Title1",
                    Author = "Author1",
                    YearPublished = 2000
                },
                new Book
                {
                    Id = 2,
                    Title = "Title2",
                    Author = "Author2",
                    YearPublished = 2000
                },
                new Book
                {
                    Id = 3,
                    Title = "Title3",
                    Author = "Author3",
                    YearPublished = 2002
                },
                 new Book
                 {
                     Id = 4,
                     Title = "Title4",
                     Author = "Author4",
                     YearPublished = 2004
                 }
                );
        }

        public DbSet<Book> Books { get; set; }
    }
}
