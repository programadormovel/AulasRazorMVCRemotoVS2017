using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AulasRazorMVCRemoto.Models
{
    public class Disco
    {
        [DisplayName("Nome do Disco")]
        [StringLength(50, ErrorMessage="O campo Nome permite no máximo 50 caracteres!")]
        public string disco { get; set; }
        [DisplayName("Nome Artista")]
        [Required]
        public string artista { get; set; }
        [DisplayName("Número de Faixas")]
        public string faixas { get; set; }
    }
}