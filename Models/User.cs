using System.ComponentModel.DataAnnotations;
namespace form_submission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string FirstName{get;set;}

        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string LastName{get;set;}

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid age.")]
        public int Age {get; set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email{get; set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]

        public string Password{get; set;}
    }
}