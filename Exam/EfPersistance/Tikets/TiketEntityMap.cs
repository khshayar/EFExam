using System.Security.Cryptography;
using Exam.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EfPersistance.Tikets;

public class TiketEntityMap :IEntityTypeConfiguration<Tiket>
{
    public void Configure(EntityTypeBuilder<Tiket> builder)
    {
        builder.ToTable("Tiket");
        builder.HasKey(_ => _.Id);
        builder.Property(_ => _.Id).UseIdentityColumn();
        builder.Property(_ => _.Price).IsRequired(false);
        builder.HasOne(_ => _.Part).WithMany(_ => _.Tikets).HasForeignKey(_ => _.PartId);
    }
}