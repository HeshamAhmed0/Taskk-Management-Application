using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApplication.DAL.Models
{
    public class Tasks:BaseEntity
    {
        public string Details { get; set; }

        public IEnumerable<Employee> Employee { get; set; }
    }
}
