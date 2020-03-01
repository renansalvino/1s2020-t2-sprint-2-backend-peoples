using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Senai.Peoples.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConnection = "Data Source=OFF-WHITE\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";
        

        public void Atualizar(UsuarioDomain usuario)
        {
            using (var con = new SqlConnection (stringConnection))
            {
                string queryAtualizar = $"UPDATE Usuarios SET "
            }
           
        }

        public void BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(UsuarioDomain usuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
