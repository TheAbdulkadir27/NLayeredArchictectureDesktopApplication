using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DataAccess.Concrete.EntityFramework
{
    using Entity.Concrete;
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Entity.Concrete.Proje> proje { get; set; }
        public DbSet<Entity.Concrete.Cutting> cutting { get; set; }
        public DbSet<Entity.Concrete.Assembly> assembly { get; set; }
        public DbSet<Entity.Concrete.Plates>  plates { get; set; }
        public DbSet<Entity.Concrete.Sevkiyat> sevkiyat { get; set; }
        public DbSet<Entity.Concrete.Single> single { get; set; }
        public DbSet<Entity.Concrete.Sofor> sofor { get; set; }
        public DbSet<Entity.Concrete.User> user { get; set; }
    }
}
