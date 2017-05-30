using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nutricionista.Models
{
    public class Contato
    {
        [Key]
        public int NumChave { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string DesNome { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "E-Mail")]
        public int DesEmail { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Assunto")]
        public string DesAssunto{ get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Mensagem")]
        public string DesMensagem { get; set; }
    }
}