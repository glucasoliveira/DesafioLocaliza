using Novo.Models;
using System.Net.Http;

namespace Novo.Services.Interface {

    public interface IVeiculoBO {

        HttpResponseMessage BuscarVeiculos(HttpRequestMessage requestMessage);

        HttpResponseMessage BuscarVeiculos(HttpRequestMessage requestMessage,int id);

        HttpResponseMessage BuscarVeiculos(HttpRequestMessage requestMessage,string placa);

        HttpResponseMessage CriarVeiculo(HttpRequestMessage requestMessage,Veiculo novoVeiculo);
    }
}