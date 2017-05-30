using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nutricionista.Models
{
    public class Clinica
    {
        [Key]
        public int NumChave { get; set; }
        
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Titulo")]
        public string DesTitulo { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Descrição")]
        public string DesDescricao { get; set; }
    }
}