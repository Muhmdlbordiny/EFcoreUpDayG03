using EFcoreUpDayG03.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreUpDayG03.Configuration
{
    internal class DepartmentConfigure : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);
            builder.Property(D => D.Name).
                HasColumnName("DepartmentName").HasColumnType("varchar").
                HasMaxLength(50);
                //IsRequired(false);
            builder.HasMany(d => d.Employees)
                           .WithOne(E => E.WorkFor)
                           .HasForeignKey(E => E.Dept_Id);
        }
    }
}
