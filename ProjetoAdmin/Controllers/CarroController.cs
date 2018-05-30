using System.Web.Http;
using ProjetoAdmin.Models;
using ProjetoAdmin.DAO;

namespace ProjetoAdmin.Controllers
{
    public class CarroController : ApiController
    {
        [HttpPost]
        public void CadastrarCarro([FromBody] Carro car)
        {
            CarroDAO carro = new CarroDAO();
            carro.InserirCarro(car);
        }

        [HttpGet]
        public Carro ObterPorId(int id)
        {
            CarroDAO carro = new CarroDAO();
            return carro.ObterPorId(id);
        }



    }
}