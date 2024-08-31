using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO03EF.Configurations
{
    internal class EmployeeConfing : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.id);

            builder.Property(e => e.name)
                .HasColumnName("EmployeeName")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(e => e.Salary).HasColumnType("decimal(18,2)");


        }
    }
}
