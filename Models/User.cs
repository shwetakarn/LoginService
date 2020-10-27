using System.ComponentModel.DataAnnotations;

namespace LoginService.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}