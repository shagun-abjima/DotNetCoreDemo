using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) 
        {
        
        }
        public DbSet<Book> Book { get; set; } 
    }
}
