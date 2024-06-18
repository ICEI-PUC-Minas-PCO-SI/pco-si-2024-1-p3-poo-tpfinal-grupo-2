using Microsoft.EntityFrameworkCore;
namespace Dados
{
    public class UrnaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseLazyLoadingProxies(true).UseSqlite($"Data Source=C:\\UrnaEletronica\\DbLocalDatabase.db");

        }

    }
}