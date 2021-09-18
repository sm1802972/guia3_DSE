using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DataBase.Models
{
    public class evento
    {
        [Key]
        public int id { get; set; }
        [StringLength(250)]
        [Required(ErrorMessage = "Debe asignar un nombre al evento ")]
        public string nombre { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime fecha { get; set; }
        public int? contacto_id { get; set; }

        public virtual contacto Contacto { get; set; }
    }
}