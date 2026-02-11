using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Creator : BaseEntity
    {
        public string Login { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
    }
}
