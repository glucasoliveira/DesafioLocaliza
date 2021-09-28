using Novo.Dao.Interfaces;
using Novo.Models;
using Novo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Novo.Services {

    public class VeiculoBOImpl : IVeiculoBO {
        private readonly IVeiculoDao dao = FactoryManager.GetVeiculoDao();

        public HttpResponseMessage BuscarVeiculos(HttpRequestMessage requestMessage) {
            List<Veiculo> veiculos;
            try {
                veiculos = dao.BuscarVeiculos();
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,veiculos);
        }

        public HttpResponseMessage BuscarVeiculos(HttpRequestMessage requestMessage,int id) {
            List<Veiculo> veiculos;
            try {
                veiculos = dao.BuscarVeiculos(id);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,veiculos);
        }

        public HttpResponseMessage BuscarVeiculos(HttpRequestMessage requestMessage,string placa) {
            List<Veiculo> veiculos;
            try {
                veiculos = dao.BuscarVeiculos(placa);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,veiculos);
        }

        public HttpResponseMessage CriarVeiculo(HttpRequestMessage requestMessage,Veiculo novoVeiculo) {
            Veiculo veiculo;
            try {
                veiculo = dao.CriarVeiculo(novoVeiculo);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,veiculo);
        }
    }
}