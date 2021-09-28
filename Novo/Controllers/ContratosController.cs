using Novo.Models;
using Novo.Services.Interface;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Novo.Controllers {

    public class ContratosController : ApiController {
        private readonly IContratoBO bo = FactoryManager.GetContratoBO();

        /// <summary>
        /// Busca todos os contratos
        /// </summary>
        [AcceptVerbs("GET")]
        [ActionName("All")]
        [ResponseType(typeof(List<Contrato>))]
        public HttpResponseMessage BuscarContratos() {
            return bo.BuscarContratos(Request);
        }

        /// <summary>
        /// Busca todos os contratos filtrando pelo id passado por parâmetro
        /// </summary>
        [AcceptVerbs("GET")]
        [ResponseType(typeof(List<Contrato>))]
        public HttpResponseMessage BuscarContratos(int id) {
            return bo.BuscarContratos(Request,id);
        }

        /// <summary>
        /// Busca todos os contratos filtrando pelo cpf passado por parâmetro
        /// </summary>
        [AcceptVerbs("GET")]
        [ResponseType(typeof(Contrato))]
        public HttpResponseMessage BuscarContratos(long cpf) {
            return bo.BuscarContratos(Request,cpf);
        }

        /// <summary>
        /// Cria um novo contrato
        /// </summary>
        [AcceptVerbs("POST")]
        [ResponseType(typeof(Contrato))]
        public HttpResponseMessage CriarContrato(Contrato Contrato) {
            return bo.CriarContrato(Request,Contrato);
        }

        /// <summary>
        /// Atualiza um contrato
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("PUT")]
        [ResponseType(typeof(Contrato))]
        public HttpResponseMessage AtualizarContrato(Contrato Contrato,int idContrato) {
            return bo.AtualizarContrato(Request,Contrato,idContrato);
        }
    }
}