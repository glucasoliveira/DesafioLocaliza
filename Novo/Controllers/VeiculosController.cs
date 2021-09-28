using Novo.Models;
using Novo.Services.Interface;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Novo.Controllers {

    [RoutePrefix("api/Veiculo")]
    public class VeiculosController : ApiController {
        private readonly IVeiculoBO bo = FactoryManager.GetVeiculoBO();

        /// <summary>
        /// Busca todos os veículos
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [ActionName("All")]
        [ResponseType(typeof(List<Veiculo>))]
        public HttpResponseMessage BuscarVeiculos() {
            return bo.BuscarVeiculos(Request);
        }

        /// <summary>
        /// Busca todos os veículos filtrando pelo id
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [ResponseType(typeof(List<Veiculo>))]
        public HttpResponseMessage BuscarVeiculos(int id) {
            return bo.BuscarVeiculos(Request,id);
        }

        /// <summary>
        /// Busca todos os veículos filtrando pela placa
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [ResponseType(typeof(Veiculo))]
        public HttpResponseMessage BuscarVeiculos(string placa) {
            return bo.BuscarVeiculos(Request,placa);
        }

        /// <summary>
        /// Cria um novo veículo
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("POST")]
        [ResponseType(typeof(Veiculo))]
        public HttpResponseMessage CriarVeiculo(Veiculo veiculo) {
            return bo.CriarVeiculo(Request,veiculo);
        }
    }
}