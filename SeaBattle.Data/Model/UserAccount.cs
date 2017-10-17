using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaBattle.Data.Model
{
    [Table("UserAccount")]
    public class UserAccount
    {
        public int Id { get; set; }

        [Required, MaxLength(128), Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        public string HashPassword { get; set; }

        [Required]
        public string Salt { get; set; }
    }
}
