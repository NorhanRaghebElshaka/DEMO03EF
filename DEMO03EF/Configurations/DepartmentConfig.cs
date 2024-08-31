using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO03EF.Configurations
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.name)
                            .HasColumnName("DepName");

            builder.HasMany(D => D.employees)
                            .WithOne(E => E.WorkFor)
                            .HasForeignKey(E => E.DepartmentId);

        }
    }
}
