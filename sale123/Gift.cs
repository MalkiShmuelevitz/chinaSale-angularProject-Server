using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace sale123
{
    public class Gift
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Donor { get; set; }
        [Required]
        [DefaultValue(10)]
        public int Price { get; set; } = 10;
        public string Image { get; set; }
        public List<User>? UsersList { get; set; }
        public User? Winner { get; set; }

    }
}
