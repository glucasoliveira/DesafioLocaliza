using Novo.Models;
using System.Collections.Generic;

namespace Novo.Dao.Interfaces {

    public interface IVeiculoDao {

        List<Veiculo> BuscarVeiculos();

        List<Veiculo> BuscarVeiculos(string placa);

        List<Veiculo> BuscarVeiculos(int id);

        Veiculo CriarVeiculo(Veiculo veiculo);
    }
}