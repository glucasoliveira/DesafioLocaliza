using Novo.Dao.Interfaces;
using Novo.Models;
using Novo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Novo.Services {

    public class ContratoBOImpl : IContratoBO {
        private readonly IContratoDao dao = FactoryManager.GetContratoDao();

        public HttpResponseMessage BuscarContratos(HttpRequestMessage requestMessage) {
            List<Contrato> contratos;
            try {
                contratos = dao.BuscarContratos();
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,contratos);
        }

        public HttpResponseMessage BuscarContratos(HttpRequestMessage requestMessage,int id) {
            List<Contrato> contratos;
            try {
                contratos = dao.BuscarContratos(id);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,contratos);
        }

        public HttpResponseMessage BuscarContratos(HttpRequestMessage requestMessage,long cpf) {
            List<Contrato> contratos;
            try {
                contratos = dao.BuscarContratos(cpf);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,contratos);
        }

        public HttpResponseMessage AtualizarContrato(HttpRequestMessage requestMessage,Contrato novoContrato,int id) {
            Contrato contrato;
            try {
                contrato = dao.AtualizarContrato(novoContrato,id);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,contrato);
        }

        public HttpResponseMessage CriarContrato(HttpRequestMessage requestMessage,Contrato novoContrato) {
            Contrato contrato;
            try {
                contrato = dao.CriarContrato(novoContrato);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,contrato);
        }
    }
}