using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAdmin.Models;
using System.Data.SqlClient;

namespace ProjetoAdmin.DAO
{
    public class AcessoDAO
    {
        public void InserirUsuario(Acesso acesso)
        {
            using (SqlConnection conn = Conexao.AbrirConexao())
            {
                using (SqlCommand cmd = new SqlCommand())
                {

 
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarUsuario(Acesso acesso)
        {
            //Implementar método
        }

        public void ObterId(int id)
        {
            //Implementar método
        }

        public bool Excluir(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"
                    DELETE FROM <nomeTabela>
                    WHERE UsuarioId = @id", conn))

                {
                    cmd.Parameters.AddWithValue("@id", id);

                    return (cmd.ExecuteNonQuery() == 1);
                }
            }
        }
    }
}