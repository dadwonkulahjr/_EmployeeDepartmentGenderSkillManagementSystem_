using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDepartmentSkillGenderManagementSystem.Models
{
    public class Skill
    {
        public Skill()
        {
            Employee = new HashSet<Employee>();
        }
        [Key]
        public int SkillId { get; set; }
        [Required]
        [Column(name: "Skill Name", TypeName = "nvarchar(50)")]
        [Display(Name ="Skill")]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Valid Charactors include (A-Z) (a-z) (' space -)")]
        public string SkillName { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual string GetSkillName
        {
            get { return SkillName; }
        }
    }
}
