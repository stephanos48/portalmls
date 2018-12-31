using Microsoft.EntityFrameworkCore;
using portalmls.API.Models;

namespace portalmls.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Value> Values { get; set; }     
        
    }
}