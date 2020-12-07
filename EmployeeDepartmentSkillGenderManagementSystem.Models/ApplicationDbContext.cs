using Microsoft.EntityFrameworkCore;


namespace EmployeeDepartmentSkillGenderManagementSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}
