using System.Web.Http;
using ProjetoAdmin.Models;
using ProjetoAdmin.DAO;

namespace ProjetoAdmin.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpPost]
        public void CadastrarUsuario([FromBody]Usuario usuario)
        {
            UsuarioDAO user = new UsuarioDAO();
            user.InserirUsuario(usuario);
        }

        [HttpPost]
        public void EditarUsuario([FromBody]Usuario usuario)
        {

        }

        [HttpGet]
        public void Excluir(int id)
        {

        }
    }
}