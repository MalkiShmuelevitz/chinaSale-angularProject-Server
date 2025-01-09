using System.ComponentModel.DataAnnotations;

namespace sale123
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        //check unique
        public string Email { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Adress { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}
