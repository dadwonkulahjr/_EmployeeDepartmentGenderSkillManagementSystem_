using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDepartmentSkillGenderManagementSystem.Models
{
    public class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [Column(name: "Department Name", TypeName = "nvarchar(50)")]
        [Display(Name ="Department Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string DepartmentName { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual string GetDepartmentName
        {
            get { return DepartmentName; }
        }
    }
}
