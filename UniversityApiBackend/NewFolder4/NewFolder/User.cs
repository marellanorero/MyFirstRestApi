using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.NewFolder4.NewFolder
{
    public class User: BaseEntity //Así hereda todo lo de Base Entity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string EmailAdress { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
