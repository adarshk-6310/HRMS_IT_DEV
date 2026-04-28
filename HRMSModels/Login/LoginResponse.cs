using System.ComponentModel.DataAnnotations;

namespace Models.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your username or email")]
        [Display(Name = "Username or Email")]
        public string UserNameOrEmail { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }
    }



    public class LoginResponse
    {
        public string Token { get; set; }
    }
}
