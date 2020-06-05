using DeaxaApp.API.Properties.Models;
using Microsoft.EntityFrameworkCore;

namespace DeaxaApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }
}