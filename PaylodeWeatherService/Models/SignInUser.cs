using System.ComponentModel.DataAnnotations;

namespace PaylodeWeatherService.Models
{
    //Model for user sign in
    public class SignInUser
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
