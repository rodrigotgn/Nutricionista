using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static Nutricionista.Utils.Enum;

namespace Nutricionista.Models
{
    public class Usuario
    {
        [Key]
        public int NumChave { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string DesNome { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string DesEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string DesSenha { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Perfil")]
        public Perfil TipPerfil { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data de Cadastro")]
        public DateTime DatCadastro { get; set; }

        [Required]
        [Display(Name = "Excluídos")]
        public bool FlgExcluido { get; set; }

        [Required]
        [Display(Name = "Bloqueado")]
        public bool FlgBloqueado { get; set; }
    }
}