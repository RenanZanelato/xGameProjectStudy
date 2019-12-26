using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using xGame.Domain.Entities;

namespace xGame.Infra.Persistence.Mapping
{
    public class MapPlayer : EntityTypeConfiguration<Player>
    {
        public MapPlayer()
        {
            ToTable("player");
            Property(p => p.Email.Endereco).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAttribute("UK_PLAYER_EMAIL") { IsUnique = true})
                .HasColumnName("email");
            Property(p => p.Name.FirstName).HasMaxLength(50).IsRequired()
                .HasColumnName("first_name");
            Property(p => p.Name.LastName).HasMaxLength(50).IsRequired()
                .HasColumnName("last_name");
            Property(p => p.Password).IsRequired()
                .HasColumnName("password");
            Property(p => p.Status).IsRequired();

        }
    }
}
