using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApplication.DAL.Models
{
    public class Department :BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreateIn { get; set; }



        public IEnumerable<Employee> Employees { get; set; }
    }
}
