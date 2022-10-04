using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Sho3lah.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){ }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author_Book> Authors_Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Administrative_Board> Administrative_Boards { get; set; }

        internal Task GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}