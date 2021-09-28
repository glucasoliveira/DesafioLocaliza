using Novo.Models;
using System.Collections.Generic;

namespace Novo.Dao.Interfaces {

    public interface IClienteDao {

        List<Cliente> BuscarClientes();

        List<Cliente> BuscarClientes(long cpf);

        List<Cliente> BuscarClientes(string cidade);

        Cliente CriarCliente(Cliente contrato);
    }
}