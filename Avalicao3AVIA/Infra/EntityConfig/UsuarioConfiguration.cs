using Avaliacao3AVIA.Models;
using System.Data.Entity.ModelConfiguration;

namespace Avaliacao3AVIA._02___Infra.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(u => u.IDUsuario);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}