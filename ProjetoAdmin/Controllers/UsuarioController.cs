using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using ProjetoAdmin.Models;

namespace ProjetoAdmin.Controllers
{
    public class UsuarioController : ApiController
    {
        string conexao = "Server=tcp:mecanico.database.windows.net,1433;Initial Catalog=mecanico;Persist Security Info=False;User ID=mecanicoadmin;Password=MA@#1234!@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        [HttpPost]
        public void Cadastrar([FromBody]Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Usuario ( cpf, nome, sobrenome, num_telefone, rg, data_nasc, email, email_alternativo, sexo) VALUES ( @cpf, @nome, @sobrenome,@num_telefone, @rg, @data_nasc, @email, @email_alternativo, @sexo )", conn))
                {

                    cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@sobrenome", usuario.Sobrenome);
                    cmd.Parameters.AddWithValue("@num_telefone", usuario.NumTelefone);
                    cmd.Parameters.AddWithValue("@rg", usuario.Rg);
                    cmd.Parameters.AddWithValue("@data_nasc", usuario.DtaNascimento);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@email_alternativo", usuario.EmailAlternativo);
                    cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        [HttpPost]
        public void Editar([FromBody]Usuario usuario)
        {

        }

        [HttpGet]
        public void Excluir(int id)
        {

        }
    }
}