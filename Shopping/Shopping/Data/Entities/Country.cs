using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        //Necesitamos velidar que el nombre no sea nulo con un Data Annotation 

        [Display(Name = "País")] //Esto es para mostrar el nombre en español para el usuario
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")] // Esto agrega un limite de caracteres para la base de datos
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //Se importa el DataAnnotations y crea una condicion con Required,
                                                                  //esto me permite acceder a más propiedades como ErrorMessage para mostrar el error,
                                                                  //también en el idioma que se necesite
        public string Name { get; set; }
    }
}
