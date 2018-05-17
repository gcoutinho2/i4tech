using ProjetoAdmin.Models;
using System.Data.SqlClient;

namespace ProjetoAdmin.DAO
{
    public class UsuarioDAO
    {
        public void InserirUsuario(Usuario usuario)
        {
            using (SqlConnection conn = Conexao.AbrirConexao())
            {
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
    }
}