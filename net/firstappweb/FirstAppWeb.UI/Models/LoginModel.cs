using System.ComponentModel.DataAnnotations;

namespace FirstAppWeb.Models
{
    public class LoginModel
    {
        //atributos, por lo general son privados y su valor puede cambiar por medio de una propiedad
        //este mecanismo se llama encapsulacion y permite ocultar datos sensibles o darles tratamientos adicionales a traves de las propiedades
        private string _user;

        //sera nuestro modelo para la vista Login, los datos cargados en este modelo viajaran hacia el controlador
        [Display(Name = "Usuario", Order = 1)] //permite que Razor le de un tratamiento especial con un nombre mas descriptivo y el orden en el que se va a renderizar el control
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe ingresar un valor en el campo Usuario")] //indica que es una propiedad obligatoria y el mensaje de error
        public string User {
            get
            {
                return _user;
            }
            set
            {
                _user = value; //es el valor que se seteo cuando se igualo la propiedad luego de instanciar la clase
            }
        } //propiedades de un modelo, el primer indicador es la visibilidad (public, private, protected),
          //el segundo es el tipo de dato (puede ser primitivo {bool, int, string} o definido por nosotros {una clase}),
          //el tercero es el nombre y por ultimo el descriptor que indica si la propiedad es de lectura y escritura, solo lectura o solo escritura

        [Display(Name = "Password", Order = 2)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe ingresar un valor en el campo Password")]
        public string Pass { get;set; } //propiedad automatica, es la manera de declarar una propiedad sin un atributo
        //pero esto no permite darle tratamiento al retorno dentro del get o a la asignacion dentro del set
    }
}