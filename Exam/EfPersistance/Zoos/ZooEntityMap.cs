using Exam.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.EfPersistance.Zoos;

public class ZooEntityMap: IEntityTypeConfiguration<Zoo>
{
    public void Configure(EntityTypeBuilder<Zoo> builder)
    {
        builder.ToTable("Zoo");
        builder.HasKey(_ => _.Id);
        builder.Property(_ => _.Id).UseIdentityColumn();
        builder.Property(_ => _.Name).IsRequired().HasMaxLength(50);
    }
}