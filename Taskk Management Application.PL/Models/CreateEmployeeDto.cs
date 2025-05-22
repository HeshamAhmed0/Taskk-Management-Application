using System.ComponentModel.DataAnnotations;
using TaskManagementApplication.DAL.Models;

namespace Taskk_Management_Application.PL.Models
{
    public class CreateEmployeeDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        public string ImageName { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Addres { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Hiring date is required")]
        public DateTime HiringDate { get; set; }




        [Required(ErrorMessage = "Department is required")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }



        public IFormFile Image {  get; set; }
        [Required(ErrorMessage = "Task is required")]
        public int TaskId { get; set; }
        public Tasks Tasks { get; set; }
    }
}
