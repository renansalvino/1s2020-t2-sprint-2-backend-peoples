using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    public class TipoUsuarioDomain
    {
        public int IdTipoUsuario { get; set; }
        [Required (ErrorMessage = "Informe o tipo de usuario qye voce possui!")]
        public string Tipos_de_usuario { get; set; }


    }
}
