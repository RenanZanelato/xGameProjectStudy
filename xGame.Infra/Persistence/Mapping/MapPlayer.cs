using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using xGame.Domain.Entities;

namespace xGame.Infra.Persistence.Mapping
{
    public class MapPlayer : EntityTypeConfiguration<Player>
    {
        public MapPlayer()
        {
            ToTable("player");

            Property(p => p.Email.Endereco).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_PLAYER_EMAIL") { IsUnique = true })).HasColumnName("email");
            Property(p => p.Name.FirstName).HasMaxLength(50).IsRequired().HasColumnName("firstName");
            Property(p => p.Name.LastName).HasMaxLength(50).IsRequired().HasColumnName("lastName");
            Property(p => p.Password).IsRequired();
            Property(p => p.Status).IsRequired();
        }
    }
}
