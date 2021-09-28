using Novo.Models;
using System.Net.Http;

namespace Novo.Services.Interface {

    public interface IContratoBO {

        HttpResponseMessage BuscarContratos(HttpRequestMessage requestMessage);

        HttpResponseMessage BuscarContratos(HttpRequestMessage requestMessage,int id);

        HttpResponseMessage BuscarContratos(HttpRequestMessage requestMessage,long cpf);

        HttpResponseMessage AtualizarContrato(HttpRequestMessage requestMessage,Contrato novoContrato,int idContrato);

        HttpResponseMessage CriarContrato(HttpRequestMessage requestMessage,Contrato novoContrato);
    }
}