using Microsoft.EntityFrameworkCore;
using TEOAG.API.Models;

namespace TEOAG.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}