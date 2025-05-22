using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApplication.BLL.Intefaces
{
    public interface IUnionInterface
    {
        IDepartmentInterface IdepartmentInterface { get; }
        IEmployeeInterface IEmployeeInterface { get; }
        ITaskInterface ITaskInterface { get; }
        Task<int> Complete();

    }
}
