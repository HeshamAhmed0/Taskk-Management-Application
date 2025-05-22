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
    public class GenericReposatory<T> : IGenericInterface<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GenericReposatory(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Create(T t)
        {
            _applicationDbContext.Set<T>().Add(t);
        }

        public void Delete(T t)
        {
            _applicationDbContext.Set<T>().Remove(t);

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var Result = await _applicationDbContext.Set<T>().ToListAsync();
            return Result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var Result = await _applicationDbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            return Result;
        }

        public void Update(T t)
        {
            _applicationDbContext.Set<T>().Update(t);

        }
    }
}
