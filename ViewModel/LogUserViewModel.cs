
using System.ComponentModel.DataAnnotations;


namespace AutoTracker.ViewModels
{
    public class LogUserViewModel
    {
        
        
        [Required(ErrorMessage = "Please enter your username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public LogUserViewModel()
        { }
    }
}
