using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nutricionista.Models
{
    public class BlogItem
    {
        [Key]
        public int NumChave { get; set; }

        [Required] 
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string DesTitulo { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Descrição")]
        public string DesDescricao { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Foto")]
        public string DesImagem { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data de criação")]
        public DateTime DatCriacao { get; set; }
    }
}