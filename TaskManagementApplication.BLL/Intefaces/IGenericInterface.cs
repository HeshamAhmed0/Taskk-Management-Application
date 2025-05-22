using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApplication.DAL.Models;

namespace TaskManagementApplication.BLL.Intefaces
{
    public interface IGenericInterface<T> where T :BaseEntity
    {  
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        void Delete(T t);
        void Update(T t);
        void Create(T t);
    }
}
