using System.ComponentModel.DataAnnotations;

namespace StoreSharp
{
    public partial class User
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        [Required]
        public Role Role { get; set; } = null!;
    }
}
