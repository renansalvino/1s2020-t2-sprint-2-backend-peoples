using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class FuncionarioDomain
    { 
        public int IdFuncionarios { get; set; }
        [Required(ErrorMessage = "Ops! Você esqueceu de colocar o seu Nome, Tome cuidado!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Ops! Você esqueceu de colocar o seu SobreNome, Tome cuidado!")]
        public string Sobrenome { get; set; }
    }
}
