using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private string stringConnection = "Data Source=OFF-WHITE\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";
        public void Atualizar(TipoUsuarioDomain tipoUsuario)
        {
            using (var con = new SqlConnection(stringConnection))
            {
                string queryAtualizarTipoUsuario = $"UDATE TipoUsuario SET Tipos_de_usuario = {tipoUsuario.Tipos_de_usuario} WHERE IdTipoUsuario = {tipoUsuario.IdTipoUsuario} ";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(queryAtualizarTipoUsuario, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public TipoUsuarioDomain BuscarPorId(int id)
        {
            using (var con = new SqlConnection(stringConnection))
            {
                string queryBuscarPorId = "SELECT IdTipoUsuario FROM TipoUsuario WHERE IdTipoUsuario = @ID";

                con.Open();

                SqlDataReader rdr;

                using (var cmd = new SqlCommand(queryBuscarPorId, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    rdr = cmd.ExecuteReader();

                    if(rdr.Read())
                    {
                        TipoUsuarioDomain tipoUsuario = new TipoUsuarioDomain
                        {
                            IdTipoUsuario = Convert.ToInt32(rdr["IdFuncionarios"])

                            ,
                            Tipos_de_usuario = rdr["Tipos De Usuario"].ToString()
                        };

                        return tipoUsuario;
                    }
                    return null;
                }

            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string queryDeletar = "DELETE FROM TipoUsuario WHERE IdTipoUsuario = @ID";

                using (var cmd = new SqlCommand(queryDeletar, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<TipoUsuarioDomain> Listar()
        {
            List<TipoUsuarioDomain> tipoUsuarios = new List<TipoUsuarioDomain>();

            using (var con = new SqlConnection(stringConnection))
            {
                string queryListar = "SELECT * FROM TipoUsuario";

                con.Open();

                SqlDataReader rdr;

                using (var cmd = new SqlCommand(queryListar, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        TipoUsuarioDomain tipoUsuario = new TipoUsuarioDomain
                        {
                            IdTipoUsuario = Convert.ToInt32(rdr[0]),

                            Tipos_de_usuario = rdr["Tipos de Usuario"].ToString()
                        };

                        tipoUsuarios.Add(tipoUsuario);

                    }
                }
            }
            return tipoUsuarios;
        }
    }
}
