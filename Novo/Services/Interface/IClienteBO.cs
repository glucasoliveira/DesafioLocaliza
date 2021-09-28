using Novo.Models;
using System.Net.Http;

namespace Novo.Services.Interface {

    public interface IClienteBO {

        HttpResponseMessage BuscarClientes(HttpRequestMessage requestMessage);

        HttpResponseMessage BuscarClientes(HttpRequestMessage requestMessage,long cpf);

        HttpResponseMessage BuscarClientes(HttpRequestMessage requestMessage,string cidade);

        HttpResponseMessage CriarCliente(HttpRequestMessage requestMessage,Cliente novoCliente);
    }
}