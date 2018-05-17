using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjetoAdmin.Models;

namespace ProjetoAdmin.DAO
{
    public class AcessoController : ApiController
    {
        AcessoDAO acesso = new AcessoDAO();

        [HttpPost]
        public void CadastrarUsuario([FromBody]Acesso acesso)
        {
            //acesso.InserirUsuario(acesso);
        }

        [HttpPost]
        public void EditarUsuario([FromBody]Acesso acesso)
        {
            //acesso.EditarUsuario(acesso);
        }

        [HttpGet]
        public void ObterId([FromBody] int id)
        {
            acesso.ObterId(id);
        }

        [HttpGet]
        public void Excluir(int id)
        {
            acesso.Excluir(id);
        }
    }
}