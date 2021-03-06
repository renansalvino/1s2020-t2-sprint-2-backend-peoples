﻿using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
<<<<<<< HEAD
        private string stringConnection = "Data Source=OFF-WHITE\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";
=======
        private string stringConnection = "Data Source=DEV20\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa@132";
>>>>>>> 98381161094f18fe6eda70c12c3e712475e3fd0d
        public void Atualizar(FuncionarioDomain funcionario)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
<<<<<<< HEAD
                string queryAtualizar = $"UPDATE Funcionarios SET Nome = '{funcionario.Nome}', Sobrenome = '{funcionario.Sobrenome}' WHERE IdFuncionarios = {funcionario.IdFuncionarios}";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(queryAtualizar, con))
                {


=======
                string queryAtualizar = "UPDATE Funcionarios SET Nome = @Nome WHERE IdFuncionarios = @ID";

                using (SqlCommand cmd = new SqlCommand(queryAtualizar, con))
                {
                    cmd.Parameters.AddWithValue("@ID", funcionario.IdFuncionarios);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", funcionario.Sobrenome);

                    con.Open();
>>>>>>> 98381161094f18fe6eda70c12c3e712475e3fd0d

                    cmd.ExecuteNonQuery();
                }
            }

        }

<<<<<<< HEAD

=======
        public void Atualizar(int id)
        {
            throw new NotImplementedException();
        }
>>>>>>> 98381161094f18fe6eda70c12c3e712475e3fd0d

        public FuncionarioDomain BuscarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string queryBuscarPorId = "SELECT IdFuncionarios, Nome, Sobrenome FROM Funcionarios WHERE IdFuncionarios = @ID ";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryBuscarPorId, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            IdFuncionarios = Convert.ToInt32(rdr["IdFuncionarios"])

                            ,
                            Nome = rdr["Nome"].ToString(),

                            Sobrenome = rdr["Sobrenome"].ToString()

                            
                        };

                        return funcionario;
                    }
                    return null;
                }
            }
        }

        public void Inserir (FuncionarioDomain funcionario)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string queryInserir = "INSERT INTO Funcionarios(Nome,Sobrenome) VALUES (@Nome,@Sobrenome)";

                SqlCommand cmd = new SqlCommand(queryInserir, con);

                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);

                cmd.Parameters.AddWithValue("@Sobrenome", funcionario.Sobrenome);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar (int id)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string queryApagar = "DELETE FROM Funcionarios WHERE IdFuncionarios = @ID";

                    using (SqlCommand cmd = new SqlCommand(queryApagar, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

<<<<<<< HEAD
=======
        public void Inserir(int id)
        {
            throw new NotImplementedException();
        }
>>>>>>> 98381161094f18fe6eda70c12c3e712475e3fd0d

        public List<FuncionarioDomain> Listar()
        {
            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string queryListar = "SELECT IdFuncionarios, Nome, Sobrenome FROM Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryListar, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            IdFuncionarios = Convert.ToInt32(rdr[0]),

                            Nome = rdr["Nome"].ToString(),

                            Sobrenome = rdr["Sobrenome"].ToString()
                        };

                        funcionarios.Add(funcionario);
                    }
                }
            }
            return funcionarios;
        }

       
        }
    }

