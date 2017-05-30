using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nutricionista.Models
{
    public class ConfiguracaoSistema
    {
        [Key]
        public int NumChave { get; set; }

        // Contato
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Endereço")]
        public string DesEndereco { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Titulo")]
        public string DesTelefone { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Horário de funcionamento")]
        public string DesHorFuncionamento { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Titulo")]
        public string DesEmail{ get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Titulo")]
        public string DesDescricaoContato { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Facebook")]
        public string DesLinkFacebook    { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Twitter")]
        public string DesLinkTwitter { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "LinkedIn")]
        public string DesLinkLinkedIn { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Instagram")]
        public string DesLinkInstagram { get; set; }
    }
}