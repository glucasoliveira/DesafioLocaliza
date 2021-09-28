using Novo.Models;
using System.Collections.Generic;

namespace Novo.Dao.Interfaces {

    public interface IContratoDao {

        List<Contrato> BuscarContratos();

        List<Contrato> BuscarContratos(long cpf);

        List<Contrato> BuscarContratos(int id);

        Contrato AtualizarContrato(Contrato contrato,int id);

        Contrato CriarContrato(Contrato contrato);
    }
}