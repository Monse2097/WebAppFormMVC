using System.ComponentModel.DataAnnotations;

namespace WebAppFormMVC.Models
{
    public class ContactMessage
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]

        public String Nombre { get; set; }

        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido")]

        public string Correo { get; set; }

        [Required(ErrorMessage ="El mensaje es obligatorio")]
        [StringLength(500, ErrorMessage ="El mensaje no puede superar los 500 caracteres")]

        public string Mensaje { get; set; }
    }
}
