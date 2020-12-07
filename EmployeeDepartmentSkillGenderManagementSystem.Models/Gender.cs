using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDepartmentSkillGenderManagementSystem.Models
{
    public class Gender
    {
        public Gender()
        {
            Employee = new HashSet<Employee>();
        }
        [Key]
        public int GenderId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(50)")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string Sex { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual string GetGenderName
        {
            get { return Sex; }
        }
    }
}
