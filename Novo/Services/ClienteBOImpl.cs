using Novo.Dao.Interfaces;
using Novo.Models;
using Novo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Novo.Services {

    public class ClienteBOImpl : IClienteBO {
        private readonly IClienteDao dao = FactoryManager.GetClienteDao();

        public ClienteBOImpl() {
        }

        public ClienteBOImpl(IClienteDao mock) {
            dao = mock;
        }

        public HttpResponseMessage BuscarClientes(HttpRequestMessage requestMessage) {
            List<Cliente> clientes;
            try {
                clientes = dao.BuscarClientes();
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,clientes);
        }

        public HttpResponseMessage BuscarClientes(HttpRequestMessage requestMessage,long cpf) {
            List<Cliente> clientes;
            try {
                clientes = dao.BuscarClientes(cpf);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,clientes);
        }

        public HttpResponseMessage BuscarClientes(HttpRequestMessage requestMessage,string cidade) {
            List<Cliente> clientes;
            try {
                clientes = dao.BuscarClientes(cidade);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,clientes);
        }

        public HttpResponseMessage CriarCliente(HttpRequestMessage requestMessage,Cliente novoCliente) {
            Cliente cliente;
            try {
                cliente = dao.CriarCliente(novoCliente);
            } catch(Exception e) {
                return requestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError,e);
            }
            return requestMessage.CreateResponse(System.Net.HttpStatusCode.OK,cliente);
        }
    }
}