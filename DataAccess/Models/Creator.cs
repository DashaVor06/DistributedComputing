using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Creator : BaseEntity
    {
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Login should be from 2 to 64 symbols")]
        public string Login { get; set; }

        [StringLength(128, MinimumLength = 8, ErrorMessage = "Password should be from 8 to 128 symbols")]
        public string Password { get; set; }

        [StringLength(64, MinimumLength = 2, ErrorMessage = "FirstName should be from 2 to 64 symbols")]
        public string FirstName { get; set; }

        [StringLength(64, MinimumLength = 2, ErrorMessage = "LastName should be from 2 to 64 symbols")]
        public string LastName { get; set; }
    }
}
