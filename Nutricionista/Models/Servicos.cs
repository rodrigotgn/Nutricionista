using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nutricionista.Models
{
    public class Servicos
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

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Imagem")]
        public string DesImagem { get; set; }
    }
}