using System.ComponentModel.DataAnnotations;

namespace sale123
{
    public class UserLogin
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
