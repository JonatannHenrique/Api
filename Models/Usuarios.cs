using System.ComponentModel.DataAnnotations;

namespace primeiraApi.Models
{
    public class Usuarios
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        public int Number { get; set; }
        public string Password { get; set; }
    }
}
