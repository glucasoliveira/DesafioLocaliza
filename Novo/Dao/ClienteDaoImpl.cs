using Novo.Dao.Interfaces;
using Novo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Novo.Dao {

    public class ClienteDaoImpl : IClienteDao {

        public List<Cliente> BuscarClientes() {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Clientes.ToList();
            }
        }

        public List<Cliente> BuscarClientes(long cpf) {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Clientes.Where(Cliente => Cliente.Cpf == cpf).ToList();
            }
        }

        public List<Cliente> BuscarClientes(string cidade) {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Clientes.Where(Cliente => Cliente.Cidade == cidade).ToList();
            }
        }

        public Cliente CriarCliente(Cliente Cliente) {
            using(var model = new EnterpriseDatabaseEntities()) {
                model.Clientes.Add(Cliente);
                model.SaveChanges();
                return BuscarClientes(Cliente.Cpf).FirstOrDefault();
            }
        }
    }
}