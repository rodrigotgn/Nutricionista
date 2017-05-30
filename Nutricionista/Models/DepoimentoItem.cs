using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nutricionista.Models
{
    public class DepoimentoItem
    {
        [Key]
        public int NumChave { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string DesNome { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Idade")]
        public int DesIdade { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Descrição")]
        public string DesDescricao { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Foto")]
        public byte[] DesImagem { get; set; }

        [Display(Name = "Foto")]
        [NotMapped]
        public HttpPostedFile file { get; set; }
    }
}