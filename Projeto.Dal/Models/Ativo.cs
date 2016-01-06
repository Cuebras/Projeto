using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Dal.Models
{
    public class Ativo
    {
        public int Id { get; set; }
        public string NomeAtivo { get; set; }
        public string TipoAtivo { get; set; }
        public string DescricaoAtivo { get; set; }
        public DateTime DataAquisicaoAtivo { get; set; }
    }
}