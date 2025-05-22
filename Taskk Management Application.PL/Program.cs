using Microsoft.EntityFrameworkCore;
using Taskk_Management_Application.PL.Models;
using TaskManagementApplication.BLL;
using TaskManagementApplication.BLL.Intefaces;
using TaskManagementApplication.BLL.Reposatories;
using TaskManagementApplication.DAL.Data.DbContexts;

namespace Taskk_Management_Application.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IUnionInterface, UnionOfWork>();
            builder.Services.AddAutoMapper(typeof(CreateEmployeeDto));
            //builder.Services.AddScoped<IDepartmentInterface,DepartmentReposatory>();
            //builder.Services.AddScoped<IEmployeeInterface, EmployeeReposatory>();
            //builder.Services.AddScoped<ITaskInterface,TaskReposatory>();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("TaskManagementApplication"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
