using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApplication.DAL.Models
{
    public class Employee :BaseEntity
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageName { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string Addres {  get; set; }
        public DateTime HiringDate { get; set; }





        public int DepartmentId { get; set; }
        public Department Department { get; set; }




        public int TaskId { get; set; }
        public Tasks Tasks { get; set; }

    }
}
