using DatingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Data
{
    public class DataContex(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> User { get; set;} //we'll get 
    }
}
