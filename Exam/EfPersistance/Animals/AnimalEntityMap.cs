using System.Security.Cryptography;
using Exam.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EfPersistance.Animals;

public class AnimalEntityMap:IEntityTypeConfiguration<Animal>
{
    public void Configure(EntityTypeBuilder<Animal> builder)
    {
        builder.ToTable("Animal");
        builder.HasKey(_ => _.Id);
        builder.Property(_ => _.Id).UseIdentityColumn();
        builder.Property(_ => _.Name).IsRequired().HasMaxLength(50);
        builder.HasOne(_ => _.Part).WithOne(_ => _.Animal).HasForeignKey<Animal>(_ => _.PartId);

    }
}