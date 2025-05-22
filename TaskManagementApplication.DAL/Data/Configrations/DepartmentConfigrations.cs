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
    public class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
           builder.Property(DI => DI.Id).UseIdentityColumn(1,1);
        }
    }
}
