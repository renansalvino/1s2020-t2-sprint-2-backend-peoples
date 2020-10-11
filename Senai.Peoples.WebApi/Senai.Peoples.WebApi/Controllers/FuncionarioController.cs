using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using Senai.Peoples.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Controllers
{

    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionarioController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }


        //Método de listar os nomes dos funcionarios
        [HttpGet]
        public IEnumerable<FuncionarioDomain> Get()
        {
            return _funcionarioRepository.Listar();
        }


        //Método de cadastrar funcionarios
        [HttpPost]
        public IActionResult Post (FuncionarioDomain novato)
        {
            _funcionarioRepository.Inserir(novato);

            return StatusCode(201);
        }
        //Método de buscar por Id
        [HttpGet("{id}")]
        public IActionResult GetId (int id)
        {
            FuncionarioDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(id);

            if (funcionarioBuscado == null)
            {
                return NotFound("Nenhum funcionário encontrado");
            }

            return Ok(funcionarioBuscado);
        }

        //Método de Inserir por Id
        [HttpPut]

        public IActionResult InserirPorId    ( FuncionarioDomain funcionarioAtualizado)
        {
            

           
=======
        public IActionResult InserirPorId    (int id, FuncionarioDomain funcionarioAtualizado)
        {
            FuncionarioDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(id);

            if (funcionarioBuscado != null)
>>>>>>> 98381161094f18fe6eda70c12c3e712475e3fd0d
            {
                return NotFound
                     (
                         new
                         {
                             mensagem = "Funcionario não encontrado",

                             erro = true
                         }
                   );
            }

            try
            {
                _funcionarioRepository.Atualizar( funcionarioAtualizado);

                return NoContent();
            }

            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        //Método de apagar por Id
        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            _funcionarioRepository.Deletar(id);

            return Ok("Funcionario deletado");
        }
    }
}
