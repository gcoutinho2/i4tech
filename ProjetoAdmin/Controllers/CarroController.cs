using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using ProjetoAdmin.Models;
using System.Data;


namespace ProjetoAdmin.Controllers
{
    public class CarroController : ApiController
    {

        string conexao = "Server=tcp:mecanico.database.windows.net,1433;Initial Catalog=mecanico;Persist Security Info=False;User ID=mecanicoadmin;Password=MA@#1234!@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        [HttpPost]
        public void Criar([FromBody] Carro carro)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Carro (modelo, ano, km, cor, montadora) VALUES (@modelo, @ano, @km, @cor, @montadora)", conn))
                {
                    // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                    cmd.Parameters.AddWithValue("@modelo", carro.Modelo);
                    cmd.Parameters.AddWithValue("@ano", carro.Ano);
                    cmd.Parameters.AddWithValue("@km", carro.Km);
                    cmd.Parameters.AddWithValue("@cor", carro.Cor);
                    cmd.Parameters.AddWithValue("@montadora", carro.Montadora);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public Carro ObterPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT mod.Nome, mont.Nome,car.Ano FROM Carro car INNER JOIN Modelo mod ON car.Id = mod.Id
                    INNER JOIN Montadora mont ON mont.id = mod.id
                    WHERE car.Id = @id", conn))

                {
                    // Esse valor poderia vir de qualquer outro lugar, como uma TextBox...
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Obtém os registros, um por vez
                        if (reader.Read() == true)
                        {
                            /*
                            Pessoa pessoa = new Pessoa();
                            pessoa.Nome= reader.GetString(0);
                            pessoa.Email = reader.GetString(1);
                            pessoa.Nascimento = reader.GetString(2);
                            pessoa.Peso = reader.GetDouble(3);
                            return pessoa;
                            */

                            return new Carro()
                            {
                                Ano = reader.GetInt32(0),
                                Km = reader.GetDouble(1),
                                Cor = reader.GetString(2),
                                Modelo = reader.GetString(3),
                                Montadora = reader.GetString(4)
                            };

                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

        }
    }
}