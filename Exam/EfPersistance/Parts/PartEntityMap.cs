using System.Security.Cryptography;
using Exam.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EfPersistance.Parts;

public class PartEntityMap:IEntityTypeConfiguration<Part>
{
    public void Configure(EntityTypeBuilder<Part> builder)
    {
        builder.ToTable("Part");
        builder.HasKey(_ => _.Id);
        builder.Property(_ => _.Id).UseIdentityColumn();
        builder.Property(_ => _.Name).IsRequired().HasMaxLength(50);
        builder.HasOne(_ => _.Zoo).WithMany(_ => _.Parts).HasForeignKey(_ => _.ZooId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Property(_ => _.Masahat).IsRequired();
        builder.Property(_ => _.Titel).IsRequired(false).HasMaxLength(500);
        builder.Property(_ => _.TedadAnimal).IsRequired(false);
    }
}