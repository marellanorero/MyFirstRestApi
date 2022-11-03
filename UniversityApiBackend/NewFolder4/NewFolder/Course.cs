using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.NewFolder4.NewFolder
{
    public class Course : BaseEntity //Así hereda todo lo de Base Entity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string ObjetivePublic { get; set; } = string.Empty;
        public string Objetives { get; set; } = string.Empty;

        //Me falta hacer lo del nivel, ver como hacer enumerado
        [Required]
        public int Level { get; set; } 

    }
}
