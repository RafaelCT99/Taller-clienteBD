using Microsoft.EntityFrameworkCore;

namespace app1_Migrations.Modelos
{
    public class AplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=clienteBD;User Id=postgres;Password=rafaelct1899;");
            }
        }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
