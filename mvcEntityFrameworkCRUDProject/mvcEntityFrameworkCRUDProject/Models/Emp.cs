using mvcEntityFrameworkCRUDProject.CustomValidator;
using System.ComponentModel.DataAnnotations;

namespace mvcEntityFrameworkCRUDProject.Models
{
    public class Emp
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [DOBCustomValidator]
        public DateOnly DateOfBith { get; set; }
        [DOJCustomValidator]
        public DateOnly DateOfJoining { get; set; }
        [DeptCustomValidator]
        public string Department { get; set; }
    }
}
