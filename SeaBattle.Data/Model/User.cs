using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaBattle.Data.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        [ForeignKey(nameof(UserAccount))]
        public int UserAccountId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Login { get; set; }
        
        public virtual UserAccount UserAccount { get; set; }
    }
}
