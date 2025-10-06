using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcEntityFrameworkCRUDProject.Models
{
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserId")]
        public int Id { get; set; }
        [Required (ErrorMessage="Name is required")]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Range(20, 60, ErrorMessage = "Age must be between 20 and 60")]
        public int age { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Please retype the correct password")]
        public string ConfirmPassword { get; set; }
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits")]
        public string phone { get; set; }
    }
}
