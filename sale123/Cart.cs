using System.ComponentModel.DataAnnotations;

namespace sale123
{
    public class Cart
    {
        [Required]
        public int Id { get; set; }
        [Required]

        public int UserId { get; set; }

        [Required]
        public List<GiftForCart> Gifts { get; set; }

     
      

    }
}
