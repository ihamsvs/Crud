using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud2.Controllers
{
    public class Usuario
    {
        [Required(AllowEmptyStrings =false, ErrorMessage ="Debe ingresar Rut. Ejem: 0-1")]
        [Display(Name = "Ingrese su Rut o pasaporte")]
        public string Rut{ get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe ingresar su nombre")]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe ingresar su apellido")]
        public string Apellido { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe ingresar su correo electrónico")]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Correo electrónico")]
        public string Email { get; set; }

        [Display(Name = "Número de telefóno")]
        [DataType(DataType.PhoneNumber)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe su número de télefono")]
        public int NumTelefono { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(15,90,ErrorMessage = "Ingrese un valor entre 15 y 90 años")]
        public int Edad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe ingresar su estatura")]
        [Display(Name ="Ingrese su estatura en CM")]
        public int Estatura { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Ingrese su estatura en KG")]
        public int Peso { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }

        public Usuario(string rut, string nombre, string apellido, string email, int num,int edad, int estatura, int peso, string pass) {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.NumTelefono = num;
            this.Edad= edad;
            this.Estatura = estatura;
            this.Peso = peso;
            this.Pass= pass;

        
        }
    }
}