using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Taskk_Management_Application.PL.Models;
using TaskManagementApplication.BLL.Intefaces;
using TaskManagementApplication.DAL.Models;

namespace Taskk_Management_Application.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnionInterface unionInterface;
        private readonly IMapper mapper;

        public EmployeeController(IUnionInterface unionInterface,IMapper mapper)
        {
            this.unionInterface = unionInterface;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
                var departments =await unionInterface.IdepartmentInterface.GetAllAsync();
                ViewData["Departments"] = departments;
                var Employees = await unionInterface.IEmployeeInterface.GetAllAsync();
                return View(Employees);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewData["departments"] = await unionInterface.IdepartmentInterface.GetAllAsync();
            ViewData["Tasks"] = await unionInterface.ITaskInterface.GetAllAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeDto createEmployeeDto)
        {
           
            if (createEmployeeDto.Image is not null)
            {
                createEmployeeDto.ImageName = Helping.DocumentSetting.Upload(createEmployeeDto.Image, "Images");
            }
            var Employee = mapper.Map<Employee>(createEmployeeDto);
            unionInterface.IEmployeeInterface.Create(Employee);
            int result=await unionInterface.Complete();
            if(result> 0)
            {
                TempData["CreateEmployee"] = "Employee Created Succes";
                return RedirectToAction("GetAll");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            ViewData["departments"] = await unionInterface.IdepartmentInterface.GetAllAsync();
            ViewData["Tasks"] = await unionInterface.ITaskInterface.GetAllAsync();
            var model = await unionInterface.IEmployeeInterface.GetByIdAsync(id);
              var  MapingResult= mapper.Map<CreateEmployeeDto>(model);
            if (model == null) return NotFound();
            return View(MapingResult);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromRoute] int id,CreateEmployeeDto createEmployeeDto)
        {
            //if(ModelState.IsValid)
            //{
           
                if(createEmployeeDto.Image is not null &&createEmployeeDto.ImageName is not null)
                {
                    Helping.DocumentSetting.Delete(createEmployeeDto.ImageName, "Images");
                   createEmployeeDto.ImageName= Helping.DocumentSetting.Upload(createEmployeeDto.Image, "Images");
                }
                if(createEmployeeDto.Image is not null)
                {
                    createEmployeeDto.ImageName =  Helping.DocumentSetting.Upload(createEmployeeDto.Image, "Images");
                }
                  var Employee = mapper.Map<Employee>(createEmployeeDto);
                  Employee.Id = id;
            unionInterface.IEmployeeInterface.Update(Employee);
                var Result= await unionInterface.Complete();
                if (Result > 0)
                {
                    return RedirectToAction("GetAll");
                }
                
            //}
            ViewData["departments"] = await unionInterface.IdepartmentInterface.GetAllAsync();
            ViewData["Tasks"] = await unionInterface.ITaskInterface.GetAllAsync();
            return View(createEmployeeDto);
        }

    }
}
