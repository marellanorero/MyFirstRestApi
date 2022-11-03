using System.ComponentModel.DataAnnotations; //Nos permite establecer una estructura, por ej, campo obligatorio, clave, requisito de longitud

namespace UniversityApiBackend.NewFolder4.NewFolder
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty; // quien lo ha creado
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public  string UpdatedBy { get; set; } = string.Empty; // Quien lo ha actualizado
        public DateTime? UpdatedAt { get; set; } //Si es null no nos da error, es opcional
        public string DeletedBy { get; set; } = string.Empty; //Quien lo ha eliminado
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false; 

    }
}
