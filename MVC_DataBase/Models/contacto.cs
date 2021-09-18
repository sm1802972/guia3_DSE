using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MVC_DataBase.Models
{
    public partial class contacto
    {
        [Key]
        public int id { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage ="campo nombre requerido")]
        [Display(Name = "Nombres:")]
        public string nombres { get; set; }
        [StringLength(100)]
        public string primerApellido { get; set; }
        [StringLength(100)]
        public string segundoApellido { get; set; }
        [StringLength(20)]
        public string numeroTelefono { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "campo numero celular requerido")]
        public string numeroCelular { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "el correo no cumple con el formato ")]
        public string email { get; set; }
    }
}