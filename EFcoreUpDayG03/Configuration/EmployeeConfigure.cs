using EFcoreUpDayG03.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreUpDayG03.Configuration
{
    internal class EmployeeConfigure : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Name)
                    .HasColumnName("EmployeeName")
                    .HasColumnType("varchar")
                    .HasMaxLength(100)
                    .IsRequired();
            builder.Property(E => E.Salary).HasColumnType("decimal(18,2)");
        }
    }
}
