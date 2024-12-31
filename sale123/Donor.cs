using System.ComponentModel.DataAnnotations;

namespace sale123
{
    public class Donor
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public string Adress { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
