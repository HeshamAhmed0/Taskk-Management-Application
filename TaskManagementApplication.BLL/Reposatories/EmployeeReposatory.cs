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
    public class EmployeeReposatory : GenericReposatory<Employee>, IEmployeeInterface
    {
        public EmployeeReposatory(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
