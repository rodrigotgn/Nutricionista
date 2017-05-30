using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nutricionista.Models
{
    public class Depoimento
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

        [NotMapped]
        public List<DepoimentoItem> DepoimentoItems { get; set; }
    }
}