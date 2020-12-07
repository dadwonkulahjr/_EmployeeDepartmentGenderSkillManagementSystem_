using EmployeeDepartmentSkillGenderManagementSystem.Models;
using EmployeeDepartmentSkillGenderManagementSystem.Services;
using EmployeeManagementSystem.UserInterfaceApiCall;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployeeDepartmentSkillGenderManagementSystem.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages()
                .AddRazorRuntimeCompilation();
            services.AddScoped<IEmployeeRepository, EmployeeRepoImplementation>();
            services.AddScoped<IDepartmentRepository, DepartmentRepoImplementation>();
            services.AddScoped<IGenderRepository, GenderRepoImplementation>();
            services.AddScoped<ISkillRepository, SkillRepoImplementation>();
            services.AddDbContext<ApplicationDbContext>(_config =>
            {
                _config.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.Configure<RouteOptions>(config =>
            {
                config.AppendTrailingSlash = true;
                config.LowercaseQueryStrings = true;
                config.LowercaseUrls = true;
            });
            services.AddHttpClient<IEmployeeService, EmployeeService>(client =>
            {
                client.BaseAddress = new System.Uri("http://localhost:64669/");
            });
            services.AddHttpClient<IDepartmentService, DepartmentService>(client =>
            {
                client.BaseAddress = new System.Uri("http://localhost:64669/");
            });
            services.AddHttpClient<IGenderService, GenderService>(client =>
            {
                client.BaseAddress = new System.Uri("http://localhost:64669/");
            });
            services.AddHttpClient<ISkillService, SkillService>(client =>
            {
                client.BaseAddress = new System.Uri("http://localhost:64669/");
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
