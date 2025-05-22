using AutoMapper;
using Taskk_Management_Application.PL.Models;
using TaskManagementApplication.DAL.Models;

namespace Taskk_Management_Application.PL.Mapping.EmployeeMapping
{
    public class EmployeeToCreateEmployeeDto:Profile
    {
        public EmployeeToCreateEmployeeDto()
        {
            CreateMap<Employee,CreateEmployeeDto>().ReverseMap();
        }
    }
}
