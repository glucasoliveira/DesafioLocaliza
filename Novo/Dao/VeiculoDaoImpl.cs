using Novo.Dao.Interfaces;
using Novo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Novo.Dao {

    public class VeiculoDaoImpl : IVeiculoDao {

        public List<Veiculo> BuscarVeiculos() {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Veiculos.ToList();
            }
        }

        public List<Veiculo> BuscarVeiculos(string placa) {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Veiculos.Where(veiculo => veiculo.Placa == placa).ToList();
            }
        }

        public List<Veiculo> BuscarVeiculos(int id) {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Veiculos.Where(veiculo => veiculo.Id == id).ToList();
            }
        }

        public Veiculo CriarVeiculo(Veiculo veiculo) {
            using(var model = new EnterpriseDatabaseEntities()) {
                model.Veiculos.Add(veiculo);
                model.SaveChanges();
                return BuscarVeiculos(veiculo.Id).FirstOrDefault();
            }
        }
    }
}