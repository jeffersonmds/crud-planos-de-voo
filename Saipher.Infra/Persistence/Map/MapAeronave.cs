using Saipher.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Saipher.Infra.Persistence.Map
{
    public class MapAeronave : EntityTypeConfiguration<Aeronave>
    {
        public MapAeronave()
        {
            ToTable("Aeronave");

            Property(p => p.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute("UK_AERONAVE_ID") { IsUnique = true })).HasColumnName("ID");
            Property(p => p.Matricula).HasMaxLength(50).IsRequired().HasColumnName("Matricula");
            Property(p => p.Tipo).HasMaxLength(50).IsRequired().HasColumnName("Tipo");
        }
    }
}
