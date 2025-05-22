using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApplication.BLL.Intefaces;
using TaskManagementApplication.BLL.Reposatories;
using TaskManagementApplication.DAL.Data.DbContexts;

namespace TaskManagementApplication.BLL
{
    public class UnionOfWork : IUnionInterface
    {
        private readonly ApplicationDbContext applicationDbContext;

        public IDepartmentInterface IdepartmentInterface { get; }

        public IEmployeeInterface IEmployeeInterface { get; }

        public ITaskInterface ITaskInterface { get;}

        public UnionOfWork(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
            IdepartmentInterface = new DepartmentReposatory(applicationDbContext);
            IEmployeeInterface = new EmployeeReposatory(applicationDbContext);
            ITaskInterface = new TaskReposatory(applicationDbContext);
        }
        public async Task<int> Complete()
        {
           return applicationDbContext.SaveChanges();
          
        }
    }
}
