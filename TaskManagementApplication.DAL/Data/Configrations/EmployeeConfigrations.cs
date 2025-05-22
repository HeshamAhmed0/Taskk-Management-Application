using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementApplication.DAL.Models;

namespace TaskManagementApplication.DAL.Data.Configrations
{
    public class EmployeeConfigrations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
           builder.Property(E => E.Id).UseIdentityColumn(1,1);
           builder.HasOne(D => D.Department)
                   .WithMany(E => E.Employees)
                   .HasForeignKey(ED => ED.DepartmentId);
            builder.HasOne(T => T.Tasks)
                   .WithMany(E => E.Employee)
                   .HasForeignKey(ET => ET.TaskId);

        }
    }
}
