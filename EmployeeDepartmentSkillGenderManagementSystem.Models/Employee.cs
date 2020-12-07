using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDepartmentSkillGenderManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required, Column(TypeName = "nvarchar(50)")]
        [Display(Name ="Firstname")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Please enter a valid name. first letter should be uppercase.")]
        [Required, Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }
        [EmailAddress, Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 0)")]
        [Required]
        public decimal? Salary { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        [Display(Name = "Date Hire")]
        public DateTime DateHire { get; set; }
        [Display(Name = "Gender"), Required(ErrorMessage ="Gender is mandatory!")]
        public int? GenderId { get; set; }
        [Display(Name = "Department"), Required(ErrorMessage ="Deparment is mandatory!")]
        public int? DepartmentId { get; set; }
        [Display(Name = "Skill"), Required(ErrorMessage ="Skill is mandatory!")]
        public int? SkillId { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Department Department { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual string GetFullName
        {
            get
            {
                return FirstName + ", " + LastName;
            }
        }
    }
}
