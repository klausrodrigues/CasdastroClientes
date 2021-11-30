using Cliente.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cliente.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Cadastro> Clientes { get; set; }
    }
}