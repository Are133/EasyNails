using EasyNails.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyNails.Infraestructure.Data.Configurations
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        #region Attributes

        #endregion

        #region Builder

        #endregion


        #region Properties

        #endregion

        #region PrivateMethods

        #endregion

        #region PublicMethods
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branch");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
               .HasColumnName("Name")
               .HasMaxLength(500)
               .IsUnicode(false);

            builder.Property(b => b.BranchGuidId)
               .HasColumnName("BranchGuidId")
               .HasMaxLength(500)
               .IsUnicode(false);

            builder.Property(b => b.Address)
               .HasColumnName("Address")
               .HasMaxLength(500)
               .IsUnicode(false);

            builder.Property(b => b.IsActive)
                .HasColumnName("IsActive");
        }
        #endregion

    }
}
