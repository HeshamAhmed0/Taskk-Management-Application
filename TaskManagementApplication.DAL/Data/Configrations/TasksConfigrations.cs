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
    public class TasksConfigrations : IEntityTypeConfiguration<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.Property(TID => TID.Id).UseIdentityColumn(1, 1);
        }
    }
}
