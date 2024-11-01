using Microsoft.EntityFrameworkCore;

namespace WebApplicationCore.Models
{
    public class BooksDbContext: DbContext
    {
        public BooksDbContext (DbContextOptions<BooksDbContext> options) : base(options) { }
        public DbSet<Author> Author { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<AuthorBooks> AuthorBooks { get; set; }
    }
}
