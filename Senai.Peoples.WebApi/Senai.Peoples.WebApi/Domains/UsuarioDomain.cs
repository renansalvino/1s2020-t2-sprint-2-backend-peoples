using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        //Define que a área é obrigatória
        [Required(ErrorMessage = "Ops! Acho que voce esqueceu de colocar o seu e-mail, mas não tem problema, o insira e tente novamente!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required (ErrorMessage = "Ops! Acho que voce esqueceu de colocar a sua Senha, mas não tem problema, a insira e tente novamente!")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8, ErrorMessage ="Ops! o campo de senha precisa de ter ao menos 8 caracteres")]
        public string Senha { get; set; }

    }
}
