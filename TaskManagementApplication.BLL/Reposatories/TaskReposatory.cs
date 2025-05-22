using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManagementApplication.BLL.Intefaces;
using TaskManagementApplication.DAL.Data.DbContexts;
using TaskManagementApplication.DAL.Models;

namespace TaskManagementApplication.BLL.Reposatories
{
    public class TaskReposatory : GenericReposatory<Tasks>, ITaskInterface
    {
        public TaskReposatory(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            {

            }
        }
    }
}
