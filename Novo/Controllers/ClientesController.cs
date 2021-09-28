using Novo.Models;
using Novo.Services.Interface;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Novo.Controllers {

    public class ClientesController : ApiController {
        private readonly IClienteBO bo = FactoryManager.GetClienteBO();

        /// <summary>
        /// Busca todos os clientes
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [ActionName("All")]
        [ResponseType(typeof(List<Cliente>))]
        public HttpResponseMessage BuscarClientes() {
            return bo.BuscarClientes(Request);
        }

        /// <summary>
        /// Busca todos os clientes filtrando pelo cpf
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [ResponseType(typeof(List<Cliente>))]
        public HttpResponseMessage BuscarClientes(long cpf) {
            return bo.BuscarClientes(Request,cpf);
        }

        /// <summary>
        /// Busca todos os clientes filtrando pela cidade
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [ResponseType(typeof(List<Cliente>))]
        public HttpResponseMessage BuscarClientes(string cidade) {
            return bo.BuscarClientes(Request,cidade);
        }

        /// <summary>
        /// Cria um novo cliente
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("POST")]
        [ResponseType(typeof(Cliente))]
        public HttpResponseMessage CriarCliente(Cliente cliente) {
            return bo.CriarCliente(Request,cliente);
        }
    }
}