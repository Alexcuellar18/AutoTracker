
using System.ComponentModel.DataAnnotations;


namespace AutoTracker.ViewModels
{
    public class LogUserViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public LogUserViewModel()
        { }
    }
}
