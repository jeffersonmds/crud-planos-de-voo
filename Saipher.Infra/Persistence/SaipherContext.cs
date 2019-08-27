using Saipher.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Saipher.Infra.Persistence
{
    public class SaipherContext : DbContext
    {
        public SaipherContext() : base("SaipherConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Aeronave> Aeronaves { get; set; }
        public IDbSet<Aeroporto> Aeroportos { get; set; }
        public IDbSet<PlanoDeVoo> PlanosDeVoo { get; set; }
        public IDbSet<Voo> Voos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            #region Adiciona entidades mapeadas
            modelBuilder.Configurations.AddFromAssembly(typeof(SaipherContext).Assembly);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
