using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApplication.BLL.Intefaces;
using TaskManagementApplication.DAL.Data.DbContexts;
using TaskManagementApplication.DAL.Models;

namespace TaskManagementApplication.BLL.Reposatories
{
    public class DepartmentReposatory : GenericReposatory<Department>, IDepartmentInterface
    {
        public DepartmentReposatory(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
