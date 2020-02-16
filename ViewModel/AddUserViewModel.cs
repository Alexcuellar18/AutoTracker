
using System.ComponentModel.DataAnnotations;


namespace AutoTracker.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Please enter your name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^[0-9]{10}$",
         ErrorMessage = "Characters are not allowed.")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Required(ErrorMessage = "Passwords do not match")]
        [Display(Name = "Verify Password")]
        [Compare("Password")]
        public string Verify { get; set; }

        [Required(ErrorMessage ="Zip Code can not be empty")]
        [RegularExpression(@"^[0-9]{5}$",
         ErrorMessage = "Characters are not allowed.")]
        [Display(Name="Zip Code")]
        public string ZipCode { get; set; }

        public AddUserViewModel() 
        { }

}
}