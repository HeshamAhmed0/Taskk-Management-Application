using TaskManagementApplication.DAL.Models;

namespace Taskk_Management_Application.PL.Models
{
    public class CreateEmployeeDto
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageName { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string Addres { get; set; }
        public DateTime HiringDate { get; set; }





        public int DepartmentId { get; set; }
        public Department Department { get; set; }



        public IFormFile Image {  get; set; }
        public int TaskId { get; set; }
        public Tasks Tasks { get; set; }
    }
}
